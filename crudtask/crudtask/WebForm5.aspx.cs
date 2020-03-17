using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudtask
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adolayer ad = new adolayer();
            int Cid = int.Parse(TextBox1.Text);
            string Course = TextBox2.Text;
            int students = int.Parse(TextBox3.Text);
            ad.insertrow(Cid,Course,students);
        }
    }
}