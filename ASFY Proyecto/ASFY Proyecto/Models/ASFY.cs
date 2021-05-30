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

        //Metodos
        public static List<Rutinas> ListarRutinas()
        {
            //Este metodo solo busca devolver la lista de productos en caso de no recibir codigo de rubro
            return _listaRutinas;
        }

        public static List<Rutinas> ListarRutinas(int codigoProgramas)
        {
            //Este metodo solo busca devolver la lista de productos en caso de recibir codigo de rubro
            List<Rutinas> devolver = new List<Rutinas>(); //Creo una lista
            for (int k = 0; k < _listaProgramas.Count; k++) //Recorro
            {
                if (codigoProgramas == _listaProgramas[k].codigo) //Pregunto si el codigo que me pasaron coincide con alguno de los existentes
                {
                    devolver.Add(_listaRutinas[k]); //En dicho caso agrego el producto que estoy mirando a la lista a devolver
                }
            }
            return devolver; //Devuelvo devolver
        }

        public static List<Programas> ListaProgramas()
        {
            //Este metodo solo busca devolver la lista de rubros
            return _listaProgramas;
        }

        public static void InicializarASFY()
        {

            _listaRutinas = BDD.ObtenerRutinas(); //Guardo la lista de productos invocando a obtener productos que accede a la base de datos
        }

        public static Rutinas ObtenerRutinas(int codigo)
        {
            Rutinas rutinas = _listaRutinas.Find(x => x.codigo.Equals(codigo)); //Declaro y busco el producto
            return rutinas; //Devuelvo el producto
        }
    }

}