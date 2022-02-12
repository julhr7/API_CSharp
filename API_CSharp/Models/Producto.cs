using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_CSharp.Models
{
    public class Producto
    {
        [Key]
        public int codProducto { get; set; }
        public string nomProducto { get; set; }
        public decimal precioProducto { get; set; }
        public string fechRegistroProducto { get; set; }
    }
}