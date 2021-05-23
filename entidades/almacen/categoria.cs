using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.almacen
{
    public class categoria
    {
        public int idcategoria { get; set; }
        public string nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }
        
    }
}
