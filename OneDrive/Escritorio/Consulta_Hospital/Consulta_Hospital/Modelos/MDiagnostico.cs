using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class MDiagnostico
    {
        public int Codigo_Diagnostico { get; set; }
        public string Tipo_Diagnostico { get; set; }
        public int Codigo_Especialista { get; set; }
        public string DPI { get; set; }
        public string Diagnosticos { get; set; }
        public string  Receta{ get; set; }
        public string Fecha_Diagnostico { get; set; }
    }
}
