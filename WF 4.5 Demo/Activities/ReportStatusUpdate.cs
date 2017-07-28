using System.Activities;
using System.Linq;
using Contracts;

namespace Activities
{
    public sealed class ReportStatusUpdate : CodeActivity
    {
        public InArgument<int> ReportID { get; set; }
        public InArgument<ReportStatusType> Status { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            int id = ReportID.Get(context);
            ReportStatusType stat = Status.Get(context);

            var ctx = new DAL.SwitchContext();
            var report = ctx.Switches.Where((r) => r.Id == id).SingleOrDefault();
            report.Status = (byte)stat;

            ctx.SaveChanges();
        }
    }
}
