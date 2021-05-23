using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.usuarios
{
    public class rol
    {
        public int idrol { get; set; }
       
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener minimo 5 caracteres")]
        public string nombre { get; set; }

        public List<condicion> condicion { get; set; }

    
    }
}
