using Consulta_Hospital.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Hospital.Controladores
{
    public class CCita
    {
        //referencia a una nueva tabla sin instanciar
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;

        public CCita()
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        public DataTable Validacitaexistente(MCita InfoCita)
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

                Cadena = "select * from Citas where Fecha='" + InfoCita.Fecha + "' and Hora='" + InfoCita.Hora + "' and Codigo_Especialista=" + InfoCita.Codigo_Especialista + "";
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

        public string InsertarCita(MCita InsertCita)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            if (Validacitaexistente(InsertCita).Rows.Count == 0)
            {
                try
                {
                    //haciendo referencia a la conexion de la base de datos
                    Conexion = new SqlConnection(CConexion);
                    //se abre la conexion
                    Conexion.Open();
                    //cadena para poder ingresar un paciente
                    Cadena = "INSERT INTO Citas VALUES('" + InsertCita.Hora + "','" + InsertCita.Fecha + "'," + InsertCita.Codigo_Especialista + ",'" + InsertCita.DPI + "','" + InsertCita.Sintomas + "')";
                    //se almacena la cadena y la conexion para poder ejecutarla
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    //se da un formato al comando tipo texto
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    //se ejecuta el comando con ExecuteNonQuery
                    Ejecutar.ExecuteNonQuery();
                    //mensaje que se mostrara en el Cuadro de dialogo.
                    Mensaje = "Cita Insertada";
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
                }
            }
            else
            {
                //mensaje que se mostrara en el Cuadro de dialogo si dado caso existe un paciente con el dpi ingresado.
                Mensaje = "Ya Existe una cita con fecha, hora y especialista asignado, por favor modifique la cita";
            }
            //se retorna el mensaje.
            return Mensaje;
        }
    }
}