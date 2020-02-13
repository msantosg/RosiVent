using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public string nombreUsuario { get; set; }
        public string claveUsuario { get; set; }
        public int acceso { get; set; }
    }
}