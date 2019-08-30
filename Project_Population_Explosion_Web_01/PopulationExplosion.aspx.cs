using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Population_Explosion_Web_01
{
    public partial class PopulationExplosion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += "\n\nIt takes 12 seconds to reach a population limit" +
                " of " + TextBox1.Text + ".";
        }
    }
}