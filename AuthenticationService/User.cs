using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace AuthenticationService
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; private set; }
        [DataMember]
        public string UserName { get; private set; }
        public User(int userId, string userName)
        {
            this.UserId = userId;
            this.UserName = userName;
        }
    }
}
