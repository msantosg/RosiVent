using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Venta
    {
        public int ventaID { get; set; }
        public int usuarioID { get; set; }
        public string nombreUsuario { get; set; }
        public int clienteID { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaVenta { get; set; }
    }
}