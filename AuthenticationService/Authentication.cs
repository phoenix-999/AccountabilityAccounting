using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;

namespace AuthenticationService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    class Authentication : IAuthentication
    {
        public User Authenticate(string userName, string password)
        {
            if(userName == "yurii" && password == "1")
            {
                return new User(1, userName);
            }
            else
            {
                throw new FaultException<SecurityTokenException>(new SecurityTokenException("Unknown Username or Password"));
            }
        }
    }
}
