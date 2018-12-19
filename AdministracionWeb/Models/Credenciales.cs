using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdministracionWeb.Models
{
    public class Credenciales
    {
        [Required]
        public string usuario { get; set; }

        [Required, DataType(DataType.Password)]
        public string clave { get; set; }

        public bool RememberMe { get; set; }

      
    }
}
