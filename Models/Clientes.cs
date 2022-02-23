using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPruebaTecnica.Models
{
    public class Clientes
    {
        [Key]
        public Guid id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoOtros { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAfiliacion { get; set; }
        public string Sexo { get; set; }
        public string ResenaPersonal { get; set; }
        public string Intereses { get; set; }


    }
}
