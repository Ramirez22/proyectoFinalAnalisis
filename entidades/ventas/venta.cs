using entidades.usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.ventas
{
   public  class venta
    {
        public int idVenta { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "TipoComprobante tiene que tener minimo 5 caracteres")]
        public string tipo_comprobante { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "serieComprobante solo 7 caracteres")]
        public string serieComprobante { get; set; }

        public DateTime fechaHora { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public List<persona> Clientes { get; set; }

        public List<usuario>Usuarios { get; set; }
        public List<estados>estados { get; set; }

    }
}

