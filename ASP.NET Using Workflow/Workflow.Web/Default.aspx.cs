using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorkflowLibrary;

namespace Workflow.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreateGreeting_Click(object sender, EventArgs e)
        {
            var username = new InArgument<string>(TextBoxName.Text);

            Greeting greeting = new Greeting { ArgUserName = username };

            IDictionary<string, object> results = WorkflowInvoker.Invoke(greeting);
            LabelGreeting.Text = results["Result"].ToString();
        }
    }
}