using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using AccountabilityAccountingDataAccess;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using NLog;

namespace AuthenticationService
{
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Authentication : IAuthentication
    {

        private static readonly Logger Log = LogManager.GetCurrentClassLogger(); //В свойствах NLog.config надо указать Копировать всегда в выходной каталог
        public User Authenticate(string login, string password)
        {
            User user;
            
            if (CheckUser(login, password, out user))
            {
                return user;
            }
            else
            {
                Log.Info("User: {0} Unknown Username or Password", login);
                throw new FaultException<SecurityTokenException>(new SecurityTokenException("Unknown Username or Password"));
            }
        }



        private bool CheckUser(string login, string password, out User user)
        {
            user = null;
            DataTable table = new DataTable();
            int? userId;
            string userName;
            User newUser;

            AccountabilityAccountingDataAccess.Authentication auth = new AccountabilityAccountingDataAccess.Authentication();

            try
            {
                table = auth.GetUserAccountabilityAccounting(login, password);
                DataRow row = table.Rows[0];

                userId = row["IdUser"] as int?; 
                userName = row["UserName"] as string;
                newUser = new User(userId, userName);
                user = newUser;                
            }
            catch(Exception ex)
            {
                Log.Error("Login: {0}, exception {1}, detail: {2}", login, ex.GetType().ToString(), ex.ToString());
                throw new FaultException<DbException>(new DbException(ex));
            }
            if (user != null && user.UserId != null) return true;
            else return false;
        }

        

    }
}
