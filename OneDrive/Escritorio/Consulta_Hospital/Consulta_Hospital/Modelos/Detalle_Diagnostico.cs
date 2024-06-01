using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class Detalle_Diagnostico
    {
        public int Codigo_Detalle {  get; set; }
        public int Codigo_Diagnostico {  get; set; }
        public int Codigo_Servicio {  get; set; }      
        public string Precio_Final { get; set; }   
    }
}
