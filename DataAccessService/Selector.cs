using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DataAccessService
{
    [DataContract]
    public class Selector
    {
        [DataMember]
        public SelectorOptions SelectorOption { get; set; }

        [DataMember]
        public Dictionary<string, string> Predicates { get; set; }

    }
}
