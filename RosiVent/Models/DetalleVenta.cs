using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class DetalleVenta
    {
        public int detalleVentaID { get; set; }
        public int ventaID { get; set; }
        public int productoID { get; set; }
        public string nombreProducto { get; set; }
        public int cantidadVenta { get; set; }
        public decimal precioVenta { get; set; }
    }
}