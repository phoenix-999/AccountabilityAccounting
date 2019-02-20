using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IdentityModel.Tokens;
using System.ServiceModel;

namespace AuthenticationService
{
    [ServiceContract]
    interface IAuthentication
    {
        [OperationContract]
        [FaultContract(typeof(SecurityTokenException))]
        User Authenticate(string userName, string password);
    }
}
