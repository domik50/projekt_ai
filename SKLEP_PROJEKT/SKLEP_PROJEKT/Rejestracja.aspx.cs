using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace SKLEP_PROJEKT
{
    public partial class rejestracja : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader odp;

        String queryStr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        private void registerUser()
    {
        String connString = System.Configuration.ConfigurationManager.ConnectionStrings["sklepConnString"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
        conn.Open();
        queryStr = "";
           
        queryStr = "SELECT * FROM klienci;)";
        
        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

        odp = cmd.ExecuteReader();
        String[] odpowiedz = new string[7];
        while (odp.HasRows && odp.Read())
        {
            odpowiedz[0] = odp.GetString(odp.GetOrdinal("miejsce"));
            odpowiedz[1] = odp.GetString(odp.GetOrdinal("DATE_FORMAT(data_od, '%e.%m.%Y')"));
            odpowiedz[2] = odp.GetString(odp.GetOrdinal("DATE_FORMAT(data_do, '%e.%m.%Y')"));
            odpowiedz[3] = odp.GetString(odp.GetOrdinal("liczba_uczestnikow_max"));
            odpowiedz[4] = odp.GetString(odp.GetOrdinal("wiek_uczestnikow_od"));
            odpowiedz[5] = odp.GetString(odp.GetOrdinal("wiek_uczestnikow_do"));
            odpowiedz[6] = odp.GetString(odp.GetOrdinal("id_kolonia"));
        }

        conn.Close();
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
             registerUser();
        }

    }
}