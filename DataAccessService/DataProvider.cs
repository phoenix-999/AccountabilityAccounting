using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationService;
using System.IdentityModel.Tokens;
using System.ServiceModel;

namespace DataAccessService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class DataProvider : IDataProvider
    {
        public DataTable GetData(Selector selector, AuthenticationService.User user)
        {
            if(!CheckUser(user))
            {
                throw new FaultException<SecurityTokenException>(new SecurityTokenException("Unknown User"));
            }

            DataTable table = SelectData(selector);

            return table;
        }

        private bool CheckUser(AuthenticationService.User user)
        {
            return false;
        }

        private DataTable SelectData(Selector selector)
        {
            DataTable table = new DataTable();

            return table;
        }
    }
}
