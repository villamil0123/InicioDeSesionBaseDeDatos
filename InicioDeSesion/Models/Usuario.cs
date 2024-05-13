using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InicioDeSesion.Models
{
    public class Usuario
    {
        public int IDusuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }


        public string ConfirmarClave { get; set; }

    }
}