using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Compra
    {
        public int compraID { get; set; }
        public int proveedorID { get; set; }
        public string nombreProveedor { get; set; }
        public DateTime fechaCompra { get; set; }
        public int noFactura { get; set; }
        public string serieFactura { get; set; }
    }
}