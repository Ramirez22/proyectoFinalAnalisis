using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace entidades.usuarios
{
    public class usuario
    {
        public int idUsuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Nombre tiene que tener minimo 5 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Apellido tiene que tener minimo 5 caracteres")]
        public string apellido { get; set; }

        public string tipoDocumento { get; set; }

       

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "numDocumento tiene que tener minimo 5 caracteres")]
        public string numDocumento { get; set; }


        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "aldea tiene que tener minimo 5 caracteres")]
        public string aldea { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Lote tiene que tener minimo 2 caracteres")]
        public string lote { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "manzana tiene que tener minimo 4 caracteres")]
        public string manzana { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 7, ErrorMessage = "Telefono tiene que tener minimo 7 caracteres")]
        public string telefono { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "email que tener minimo 10 caracteres")]
        public string email { get; set; }


        [Required]
        public byte password_hash { get; set; }

        [Required]
        public byte password_sal { get; set; }


        public List<rol> roles { get; set; }

        public List <condicion>condiciones { get; set; }

    }
}
