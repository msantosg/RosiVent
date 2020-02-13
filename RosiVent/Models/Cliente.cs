using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Cliente
    {
        public int clienteID { get; set; }
        public Int64 nitCliente { get; set; }
        public string nombreCliente { get; set; }
        public string direccionCliente { get; set; }
    }
}