using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Num1,Num2,ADD;
            Num1 = int.Parse(TextBox1.Text);
            Num2 = int.Parse(TextBox2.Text);
            ADD=Num1 +Num2;

            Label2.Visible = true;
            Label2.Text = "Total is:" + ADD;
        }
    }
}