using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace AuthenticationService
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int? UserId { get; private set; }
        [DataMember]
        public string UserName { get; private set; }
        public User(int? userId, string userName)
        {
            this.UserId = userId;
            this.UserName = userName;
        }

        public static string ComputeHash(string plaintext)
        {
            HashAlgorithm mhash = new SHA1CryptoServiceProvider();
            byte[] bytValue = Encoding.UTF8.GetBytes(plaintext);
            byte[] bytHash = mhash.ComputeHash(bytValue);
            mhash.Clear();
            Console.WriteLine(Convert.ToBase64String(bytHash));
            return Convert.ToBase64String(bytHash);
        }
    }
}
