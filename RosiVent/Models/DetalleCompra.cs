using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class DetalleCompra
    {
        public int detalleCompraID { get; set; }
        public int compraID { get; set; }
        public int productoID { get; set; }
        public int cantidadCompra { get; set; }
        public decimal precioCompra { get; set; }
    }
}