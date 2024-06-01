using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class MCita
    {
        public int Codigo_Cita { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public int Codigo_Especialista { get; set; }
        public string DPI { get; set; }
        public string Sintomas { get; set; }
    }
}
