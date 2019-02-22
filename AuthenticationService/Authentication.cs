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


namespace AuthenticationService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Authentication : IAuthentication
    {


        public User Authenticate(string login, string password)
        {
            User user;
            if(CheckUser(login, password, out user))
            {
                return user;
            }
            else
            {
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

                userId = row["IdUser"] as int?; //исправить IdUser
                userName = row["UserName"] as string;
                newUser = new User(userId, userName);
                user = newUser;                
            }
            catch(Exception ex)
            {
                throw new FaultException<DbException>(new DbException(ex));
            }
            if (user != null && user.UserId != null) return true;
            else return false;
        }

    }
}
