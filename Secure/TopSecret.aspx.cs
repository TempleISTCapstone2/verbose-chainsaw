using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeScanning.Secure
{
    public partial class TopSecret : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();

            CallDatabase(id);
        }



        protected void CallDatabase(string id)
        {
            
        }
    }
}