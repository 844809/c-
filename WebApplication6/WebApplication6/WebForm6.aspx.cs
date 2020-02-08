using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            ADOlayer ad = new ADOlayer();
            int tid = int.Parse(TextBox1.Text);
            string tname = TextBox2.Text;
            string tlocation = TextBox3.Text;
            string domain = TextBox4.Text;
            string StartDate = TextBox5.Text;
            ad.insertrow(tid, tname, tlocation, domain, StartDate);
        }
    }
}