using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Hospital.Modelos;
using System.Reflection;
using Consulta_Hospital.Vistas;

namespace Consulta_Hospital.Controladores
{
    public class Reportes
    {
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;
        public Reportes() 
        {
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }
        
        public DataTable HorarioGeneral (MCita Cita)
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();
                Cadena = "select c.Hora,c.Fecha,es.Nombre_Completo as Especialista, pa.Nombre_Paciente+pa.Apellido_Paciente as Paciente from Citas c inner join Especialistas es on es.Codigo_Especialista = c.Codigo_Especialista inner join Pacientes pa on pa.DPI = c.DPI where Fecha = '"+Cita.Fecha+"'";
                // Variable para ejecutar el comando o cadena del select
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //El resultado se guarda en la variable Adaptador
                Adaptador = new SqlDataAdapter(Ejecutar);
                //todo lo que se tiene almacenado en la variable Adaptador se formatea con Fill y se guarda en la tabla
                //que se declaro al principio.
                Adaptador.Fill(dt);
            }
            //exepciones.
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //finaliza la conexion y todo lo que se ejecuto y almaceno
                Conexion.Dispose();
                Ejecutar.Dispose();
                Adaptador.Dispose();
            }
            //cuando la tabla esta llena se regresa a la clase que invoco este funcion.
            return dt;
        }

        public DataTable Historial(MDiagnostico dpi)
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();
                Cadena ="select D.Fecha_Diagnostico, e.Nombre_Completo Especialista, e.Especialidad, D.Diagnostico from  Diagnosticos D inner join Especialistas e on e.Codigo_Especialista = D.Codigo_Especialista where D.DPI = '"+dpi.DPI+"'";
                // Variable para ejecutar el comando o cadena del select
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //El resultado se guarda en la variable Adaptador
                Adaptador = new SqlDataAdapter(Ejecutar);
                //todo lo que se tiene almacenado en la variable Adaptador se formatea con Fill y se guarda en la tabla
                //que se declaro al principio.
                Adaptador.Fill(dt);
            }
            //exepciones.
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //finaliza la conexion y todo lo que se ejecuto y almaceno
                Conexion.Dispose();
                Ejecutar.Dispose();
                Adaptador.Dispose();
            }
            //cuando la tabla esta llena se regresa a la clase que invoco este funcion.
            return dt;
        }
    }
}
