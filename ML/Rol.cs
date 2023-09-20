﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Rol
    {
        [Required]
        [Display(Name = "Rol")]
        public int idRol { get; set; }
        public string Nombre { get; set; }
        public List<object> Roles { get; set; }
    }
}
