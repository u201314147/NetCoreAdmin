using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdministracionWeb.Models
{
    public class Empleados
    {
        [Key]
        public int id_empleado { get; set; }

        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int id_sexo { get; set; }
        public int id_estadocivil { get; set; }
        public int id_tiposangre { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_contrato { get; set; }
        public string foto { get; set; }
    }
}
