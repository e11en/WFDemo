using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class SwitchReportConfirmation : SwitchReport
    {
        [DataMember]
        public int ReportID { get; set; }

        [DataMember]
        public ReportStatusType Status { get; set; }
    }
}
