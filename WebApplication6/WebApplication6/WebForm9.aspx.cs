using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication6
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ADOlayer ad = new ADOlayer();
                var data = ad.Getallrecords();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        protected void showdata(object sender, EventArgs e)
        {

        }
    }
}