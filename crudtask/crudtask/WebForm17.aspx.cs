﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudtask
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adolayer ad = new adolayer();
            int Fid = int.Parse(TextBox1.Text);
            var d = ad.getfac(Fid);
            GridView1.DataSource = d;
            GridView1.DataBind();
        }
    }
}