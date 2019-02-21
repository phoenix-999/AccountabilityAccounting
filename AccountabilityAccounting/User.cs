using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
