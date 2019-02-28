using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationService;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using NLog;
using AccountabilityAccountingDataAccess;
using System.Transactions;

namespace DataAccessService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class DataProvider : IDataProvider
    {
        protected static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public DataTable GetData(Selector selector, AuthenticationService.User user)
        {
            if(!CheckUser(user))
            {
                Log.Info("User: {}, Detail: Unknown User", user.UserName);
                throw new FaultException<SecurityTokenException>(new SecurityTokenException("Unknown User"));
            }

            try
            {
                DataTable table = SelectData(user, selector);
                return table;
            }
            catch (Exception ex)
            {
                Log.Error("UserId: {0}, detail: {1}", user.UserId, ex.ToString());
                throw new FaultException<DbException>(new DbException(ex));
            }

            
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateData(Updater updater, DataTable table, AuthenticationService.User user)
        {
            Log.Info("Transactions\nUser: {0}, TransactionId: {1}", user.UserName, Transaction.Current.TransactionInformation.DistributedIdentifier);
            if (!CheckUser(user))
            {
                Log.Info("User: {}, Detail: Unknown User", user.UserName);
                throw new FaultException<SecurityTokenException>(new SecurityTokenException("Unknown User"));
            }

            try
            {
                UpdateDataFromOptions(updater, table, user);
            }
            catch(Exception ex)
            {
                Log.Error("UserId: {0}, detail: {1}", user.UserId, ex.ToString());
                throw new FaultException<DbException>(new DbException(ex));
            }
        }

        private bool CheckUser(AuthenticationService.User user)
        {
            if (user != null) return true;
            return false;
        }

        private DataTable SelectData(User user, Selector selector)
        {
            DataTable table = new DataTable();
            DataSelector select = new DataSelector();

            if(selector.SelectorOption == SelectorOptions.GetSummary)
            {
                table = select.GetSummary(selector.Predicates["dateStart"], selector.Predicates["dateEnd"]);                
            }
            else if(selector.SelectorOption == SelectorOptions.GetSign)
            {
                table = select.GetSigns();
            }
            else if (selector.SelectorOption == SelectorOptions.GetProjects)
            {
                table = select.GetProjects();
            }
            else if (selector.SelectorOption == SelectorOptions.GetAccountables)
            {
                table = select.GetAccountables();
            }
            else if (selector.SelectorOption == SelectorOptions.GetItems)
            {
                table = select.GetItems();
            }

            return table;
        }

        private void UpdateDataFromOptions(Updater updater, DataTable table, AuthenticationService.User user)
        {
            DataUpdater update = new DataUpdater();
            if (updater.UpdaterOption == UpdaterOptions.UpdateSummary)
            {
                update.UpdateSummary(table, user.UserName);

            }
        }
    }
}
