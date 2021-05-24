using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASFY_Proyecto.Models
{
    public static class BDD
    {
        private static string _connectionString = "Server=localhost\\sqlexpress; Database=ASFY; Trusted_Connection=True";

        private static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            return con;
        }

        private static bool Desconectar(SqlConnection con)
        {
            bool pudoDesconectar;
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                pudoDesconectar = true;
            }
            else
            {
                pudoDesconectar = false;
            }
            return pudoDesconectar;
        }
    }
}
