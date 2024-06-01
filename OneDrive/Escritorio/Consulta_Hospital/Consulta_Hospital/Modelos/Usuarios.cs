using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Modelos
{
    public class Usuarios
    {
        public int Codigo_Usuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Codigo_Especialista { get; set; }
        public int Estado_Usuario { get; set; }
        public string Rol {  get; set; }

    }
}
