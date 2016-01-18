using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace SKLEP_PROJEKT
{
    public partial class dodanie_produktu : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;

        MySql.Data.MySqlClient.MySqlCommand cmd;
   

        String queryStr;
  

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void registerproduct()
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["sklepConnString"].ToString();

            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
          
            queryStr = "insert into mydb.produkty (nazwa, opis, cena, id_kategorie_producenci) values ('" + nazwa.Text + "','" + opis.Text + "','" + cena.Text + "','" + kategoria.Text +  "')";
          
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);
           

            cmd.ExecuteNonQuery();
         

            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            registerproduct();
        }
    }
}