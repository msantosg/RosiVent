using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Producto
    {
        public int productoID { get; set; }
        public string nombreProducto { get; set; }
        public string unidadMedida { get; set; }
        public int existenciaProducto { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public int categoriaID { get; set; }
        public string nombreCategoria { get; set; }
        public int proveedorID { get; set; }
        public string nombreProveedor { get; set; }
    }
}