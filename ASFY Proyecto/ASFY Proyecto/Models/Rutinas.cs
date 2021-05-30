using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASFY_Proyecto.Models
{
    public class Rutinas
    {
        private int _codigo;
        private int _codigoProgramas;
        private string _Nombre;


        public Rutinas(int codigo, int codigoProgramas, string Nombre)
        {
            _codigo = codigo;
            _codigoProgramas = codigoProgramas;
            _Nombre = Nombre;

        }

        public int codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public int codigoProgramas
        {
            get
            {
                return _codigoProgramas;
            }

            set
            {
                _codigoProgramas = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

    }

}