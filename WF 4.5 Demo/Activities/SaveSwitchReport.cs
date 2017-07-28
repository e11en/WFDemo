using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Activities
{
    public sealed class SaveSwitchReport : CodeActivity<int>
    {

        public InArgument<Contracts.SwitchReport> Report { get; set; }

        protected override int Execute(CodeActivityContext context)
        {
            var report = Report.Get(context);
            if (report != null)
            {
                var rep = new DAL.Switch
                {
                    Date = report.Date,
                    EAN = report.EAN,
                    Status = (byte)ReportStatusType.Submitted
                };

                var ctx = new DAL.SwitchContext();
                ctx.Switches.Add(rep);
                //ctx.People.AddObject(rep.Employee);
                ctx.SaveChanges();

                return rep.Id;
            }
            return 0;
        }
    }
}
