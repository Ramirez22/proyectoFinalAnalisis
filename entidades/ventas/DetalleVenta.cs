using System;
using System.Collections.Generic;
using System.Text;

namespace entidades.ventas
{
   public class DetalleVenta
    {
        public int Cantidad { get; set; }
        public decimal PrecioDetalleVenta { get; set; }
        public decimal descuento { get; set; }

        public List<venta> Ventas { get; set; }
        public List<articulo>Articulo { get; set; }
    }
}
