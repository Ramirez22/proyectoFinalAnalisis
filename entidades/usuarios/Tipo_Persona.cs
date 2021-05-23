using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.usuarios
{
    public class Tipo_Persona
    {
        public int idpersona { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "descripcion debe tener minimo 10 caracteres")]
        public string descripcion { get; set; }


    }
}
