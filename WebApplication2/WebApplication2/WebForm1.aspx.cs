using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Plus_Click1(object sender, EventArgs e)
        {
            String N1 = txtNumber1.Text;
            String N2 = txtNumber2.Text;
            int result = Convert.ToInt32(N1) + Convert.ToInt32(N2);
            RES.Text = Convert.ToString(result);
        }

        protected void Subtract_Click1(object sender, EventArgs e)
        {
            String N1 = txtNumber1.Text;
            String N2 = txtNumber2.Text;
            int result = Convert.ToInt32(N1) - Convert.ToInt32(N2);
            RES.Text = Convert.ToString(result);
        }

        protected void Multiply_Click1(object sender, EventArgs e)
        {
            String N1 = txtNumber1.Text;
            String N2 = txtNumber2.Text;
            int result = Convert.ToInt32(N1) * Convert.ToInt32(N2);
            RES.Text = Convert.ToString(result);

        }

        protected void Devide_Click(object sender, EventArgs e)
        {
            String N1 = txtNumber1.Text;
            String N2 = txtNumber2.Text;
            double result = Convert.ToDouble(N1) / Convert.ToDouble(N2);
            RES.Text = Convert.ToString(result);
        }

    }
}