﻿using System;
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

            DataTable table = SelectData(user, selector);

            return table;
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
                try
                {
                    table = select.GetSummary(selector.Predicates["dateStart"], selector.Predicates["dateEnd"]);
                }
                catch(Exception ex)
                {
                    Log.Error("UserId: {0}, detail: {1}", user.UserId, ex.ToString());
                    throw new FaultException<DbException>(new DbException(ex));
                }
            }

            return table;
        }
    }
}
