using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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


    }
}