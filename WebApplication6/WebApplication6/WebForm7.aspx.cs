using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update(object sender, EventArgs e)
        {
            ADOlayer ad = new ADOlayer();
            int tid = int.Parse(TextBox1.Text);
            string tname = TextBox2.Text;
            ad.updatedata(tid, tname);
        }
    }
}