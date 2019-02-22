using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AuthenticationService
{
    [DataContract]
    public class DbException
    {
        [DataMember]
        public string Detail { get; private set; }
        public DbException(Exception ex)
        {
            Detail = string.Format("Ошибка в процессе работы с базой данных. Детали: {0}", ex.Message);
        }
    }
}
