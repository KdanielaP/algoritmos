using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class Servicio_medico
    {
        public int Codigo_servicio { get; set; }
        public string Nombre_Servicio { get; set; }
        public float Precio_Minimo { get; set; }
        public float Precio_Maximo { get; set; }
        public float Precio_Actual { get; set; }
    }
}
