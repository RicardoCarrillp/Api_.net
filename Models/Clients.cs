using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiPruebaTecnica.Models
{
    public class Clients
    {   [Key]
        public Guid id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }
        public int Identificación { get; set; }
        public int TelefonoCelular { get; set; }
        public int TeléfonoOtros { get; set; }
        public string Direccion { get; set; }
        public int FechaNacimiento { get; set; }
        public int FechaAfiliacion { get; set; }
        public string Sexo { get; set; }
        public string ResenaPersonal { get; set; }
        public string Intereses { get; set; }


    }
}
