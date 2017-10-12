using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloServiceClient
{
    /// <summary>
    /// Deploy the client on IIS and run the project. Which will start the service host.
    /// Open this page in the browser which will hit the service host.
    /// </summary>
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnShowMessage_Click(object sender, EventArgs e)
        {
            SayHelloService.SayHelloServiceClient client = new SayHelloService.SayHelloServiceClient("BasicHttpBinding_ISayHelloService");
            lblMessage.Text=client.SayHello(txtMessage.Text);
        }
    }
}