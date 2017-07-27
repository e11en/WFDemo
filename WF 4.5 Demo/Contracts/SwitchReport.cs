using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    [DataContract]
    public class SwitchReport
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string EAN { get; set; }
    }
}
