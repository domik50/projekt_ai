using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SKLEP_PROJEKT
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("logowanie_klienta.aspx", false);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrowanie_klientami.aspx", false);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("dodanie_produktu.aspx", false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sklep.aspx", false);
        }
    }
}