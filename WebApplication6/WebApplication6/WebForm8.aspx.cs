using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Showbid(object sender, EventArgs e)
        {
        }

        protected void showbid(object sender, EventArgs e)
        {

            ADOlayer ad = new ADOlayer();
            int tid = int.Parse(TextBox1.Text);
            var data = ad.getstu(tid);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}