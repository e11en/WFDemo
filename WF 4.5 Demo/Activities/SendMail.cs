using System.Activities;
using System.Net.Mail;

namespace Activities
{
    public sealed class SendMail : CodeActivity
    {
        public InArgument<string> RecipientAddress { get; set; }
        public InArgument<string> FromAddress { get; set; }
        public InArgument<string> Subject { get; set; }
        public InArgument<string> MailBody { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var msg = new MailMessage(FromAddress.Get(context),
                                      RecipientAddress.Get(context),
                                      Subject.Get(context),
                                      MailBody.Get(context));

            using (var client = new SmtpClient())
            {
                client.Send(msg);
            }
        }
    }
}
