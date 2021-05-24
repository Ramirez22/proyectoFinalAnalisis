using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.ventas
{
   public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal PrecioDetalleVenta { get; set; }
        [Required]
        public decimal descuento { get; set; }
        
        public List<venta> Ventas { get; set; }
        public List<articulo>Articulo { get; set; }
    }
}
