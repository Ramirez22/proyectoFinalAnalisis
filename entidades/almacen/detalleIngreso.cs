using entidades.almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace entidades
{
    public class detalleIngreso
    {
        public int iddetalle_ingreso { get; set; }

        public int cantidad { get; set; }

        public decimal precio_detalle { get; set; }

        public List <ingreso> ingresos { get; set; }

        public List <articulo> articulos { get; set; }

    }
}
