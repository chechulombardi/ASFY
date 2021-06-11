using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASFY_Proyecto.Models
{
    public class ASFY
    {
        private static List<Rutinas> _listaRutinas = new List<Rutinas>();
        private static List<Programas> _listaProgramas = new List<Programas>();
        private static List<UnPrograma> _listaUnPrograma = new List<UnPrograma>();


        public static List<Rutinas> listaRutinas
        {
            get
            {
                return _listaRutinas;
            }

            private set
            {
                _listaRutinas = value;
            }
        }
        public static List<Programas> listaProgramas
        {
            get
            {
                return _listaProgramas;
            }

            private set
            {
                _listaProgramas = value;
            }
        }

        public static List<UnPrograma> listaUnPrograma
        {
            get
            {
                return _listaUnPrograma;
            }

            private set
            {
                _listaUnPrograma = value;
            }
        }

        //Metodos
        public static List<Rutinas> ListarRutinas()
        {
            return _listaRutinas;
        }

        public static List<UnPrograma> ListarUnPrograma()
        {
            return _listaUnPrograma;
        }

        public static List<Rutinas> ListarRutinas(int codigoProgramas)
        {
            List<Rutinas> devolver = new List<Rutinas>();
            for (int k = 0; k < _listaProgramas.Count; k++)
            {
                if (codigoProgramas == _listaProgramas[k].codigo)
                {
                    devolver.Add(_listaRutinas[k]);
                }
            }
            return devolver;
        }

        public static List<UnPrograma> ListarUnPrograma(int codigo)
        {
            List<UnPrograma> devolver = new List<UnPrograma>();
            for (int k = 0; k < _listaUnPrograma.Count; k++)
            {
                if (codigo == _listaUnPrograma[k].codigo)
                {
                    devolver.Add(_listaUnPrograma[k]);
                }
            }
            return devolver;
        }

        public static List<Programas> ListaProgramas()
        {
            //Este metodo solo busca devolver la lista de programas
            return _listaProgramas;
        }

        public static void InicializarASFY()
        {

            _listaRutinas = BDD.ObtenerRutinas(); //Guardo la lista de rutinas invocando a obtener rutinas que accede a la base de datos
            _listaUnPrograma = BDD.ObtenerUnPrograma(); 
        }

        public static Rutinas ObtenerRutinas(int codigo)
        {
            Rutinas rutinas = _listaRutinas.Find(x => x.codigo.Equals(codigo)); //Declaro y busco el rutinas
            return rutinas; //Devuelvo las rutinas 
        }

        public static UnPrograma ObtenerProgramas(int codigo)
        {
            UnPrograma programas = _listaUnPrograma.Find(x => x.codigo.Equals(codigo));
            return programas;  //Devuelve una lista de los programas
        }

    }

}