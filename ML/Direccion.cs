using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Direccion
    {
        public int IdDireccion {  get; set; }

        [Required]
        public string Calle {  get; set; }
        public string NumeroInterior { get; set; }

        [Required]
        [MinLength(1), MaxLength(5)]
        public string NumeroExterior { get; set; }
        public ML.Colonia Colonia { get; set; }
    }
}
