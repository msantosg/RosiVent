using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RosiVent.Models
{
    public class Proveedor
    {
        public int proveedorID { get; set; }
        public Int64 nitProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string direccionProveedor { get; set; }
        public Int64 telefonoProveedor { get; set; }
    }
}