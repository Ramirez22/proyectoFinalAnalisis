using entidades.almacen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades
{
    public class articulo
    {
        public int idarticulo { get; set; }

        public string codigo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener minimo 5 caracteres")]
        public string nombre { get; set; }

        public decimal PrecioVenta { get; set; }

        public int stock { get; set; }

        [Required]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "La descripcion tiene que tener minimo 5 caracteres")]
        public string descripcion { get; set; }

        public List<categoria> categorias{get;set;}
    }
}
