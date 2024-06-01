using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class MAgregar_Paciente
    {
        public string DPI { get; set; }
        public string Nombre_Paciente { get; set; }
        public string Apellido_Paciente { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Tipo_Sangre { get; set; }
    }
}
