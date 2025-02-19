﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASFY_Proyecto.Models
{
    public static class BDD
    {
        private static string _connectionString = @"Server=LAPTOP-F61O4L1M\SQLEXPRESS01; Database=ASFY; Trusted_Connection=True";

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

        public static List<Rutinas> ObtenerRutinas()
        {
            List<Rutinas> listaRutinas = new List<Rutinas>();
            SqlConnection con = BDD.Conectar();
            SqlCommand consulta = con.CreateCommand();
            consulta.CommandText = "Select * from Rutinas";
            SqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                int Id= Convert.ToInt32(lector["Id"]);
                int IdProgrmas = Convert.ToInt32(lector["IdPrograma"]);
                string Nombre = lector["Nombre"].ToString();
                


                Rutinas rutinas = new Rutinas(Id, IdProgrmas, Nombre);
                listaRutinas.Add(rutinas);
            }
            BDD.Desconectar(con);
            return listaRutinas;
        }

        public static List<UnPrograma> ObtenerUnPrograma()
        {
            List<UnPrograma> listaUnPrograma = new List<UnPrograma>();
            SqlConnection con = BDD.Conectar();
            SqlCommand consulta = con.CreateCommand();
            consulta.CommandText = "Select * from Programas";
            SqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                int Id = Convert.ToInt32(lector["Id"]);
                string Nombre = lector["Nombre"].ToString();
                string Descripcion = lector["Descripcion"].ToString();
                int IdCategoria = Convert.ToInt32(lector["IdCategoria"]);


                UnPrograma programas = new UnPrograma(Id, Nombre, Descripcion, IdCategoria);
                listaUnPrograma.Add(programas);
            }
            BDD.Desconectar(con);
            return listaUnPrograma;
        }

        public static List<Rutinas> ObtenerRutinasPorProgramas(int codigoProgramas)
        {
            List<Rutinas> listaRutinasPorProgramas = new List<Rutinas>();
            SqlConnection con = BDD.Conectar();
            SqlCommand consulta = con.CreateCommand();
            consulta.CommandText = "Select * from Rutinas where IdPrograma = @Id";
            consulta.Parameters.AddWithValue("@Id", codigoProgramas);
            SqlDataReader lector = consulta.ExecuteReader();
            while (lector.Read())
            {
                int Id = Convert.ToInt32(lector["Id"]);
                int IdProgrmas = Convert.ToInt32(lector["IdPrograma"]);
                string Nombre = lector["Nombre"].ToString();  

                Rutinas rutinas = new Rutinas(Id, IdProgrmas, Nombre);
                listaRutinasPorProgramas.Add(rutinas);
            }
            BDD.Desconectar(con);
            return listaRutinasPorProgramas;
        }

    }
}
