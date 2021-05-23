using entidades.usuarios;
using entidades.ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.almacen
{
    public class ingreso
    {
        public int idingreso { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "TipoComprobante tiene que tener minimo 5 caracteres")]
        public string tipoComprobante { get; set; }

        [Required]
        [StringLength(7,  ErrorMessage = "serieComprobante solo 7 caracteres")]
        public string serieComprobante { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "numComprobante tiene que tener minimo 5 caracteres")]
        public string numComprobante { get; set; }

        public DateTime fechaHora { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public List<persona> personas { get; set; }

        public List<usuario> usuarios { get; set; }

        public List<estados> estados { get; set; }
    }
}
