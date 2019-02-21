using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountabilityAccounting.AuthenticationService;

namespace AccountabilityAccounting
{
    class  UserData
    {
        public static AuthenticationService.User User { get; private set; }
        
        public UserData(AuthenticationService.User user)
        {
            UserData.User = user;
        }
    }
}
