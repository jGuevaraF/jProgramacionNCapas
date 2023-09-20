using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(2) ,MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required]
        [MinLength(8), MaxLength(20)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required]
        public string Sexo { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [Phone]
        public string Celular { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string CURP { get; set; }
        public string Imagen {  get; set; }
        public bool Status {  get; set; }
        public List<object> Usuarios { get; set; }
        public ML.Rol Rol { get; set; }
        public ML.Direccion Direccion { get; set; }
    }
}
