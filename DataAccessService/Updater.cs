using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessService
{
    [DataContract]
    public class Updater
    {
        [DataMember]
        public UpdaterOptions UpdaterOption { get; set; }
    }
}
