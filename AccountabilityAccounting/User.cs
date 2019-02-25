using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccountabilityAccounting.AuthenticationService
{
    public partial class User: object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        private static User currentUser;
        public static User Current
        {
            get
            {
                return currentUser;
            }
            set
            {
                if(currentUser == null)
                {
                    currentUser = value;
                }
            }
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

        public static implicit operator DataProviderService.User (AuthenticationService.User authenticatedUser)
        {
            DataProviderService.User user = new DataProviderService.User();
            user.UserId = authenticatedUser.UserId;
            user.UserName = authenticatedUser.UserName;
            return user;
        }
    }
}
