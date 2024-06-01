using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Hospital.Modelos;

namespace Consulta_Hospital.Controladores
{
    public class CServicio_Medico
    {

        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;

        public CServicio_Medico()
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        public DataTable BuscarServicioN(Servicio_medico Inforservicio)
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

                //if para verificar si DPI es diferente a nada
                if (!Inforservicio.Nombre_Servicio.Equals(""))
                {
                    //si Nombre_Servicio contiene algun caracter busca el paciente por medio del Nombre del servicio
                    Cadena = "select * from Servicios where Nombre_Servicio='" + Inforservicio.Nombre_Servicio + "'";
                }
                else
                {
                    //si Nombre_Servicio No contiene nada se realiza una consulta General.
                    Cadena = "select * from Servicios";
                }
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

        public string InsertarServicio(Servicio_medico InsertServicio)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            if (BuscarServicioN(InsertServicio).Rows.Count == 0)
            {
                try
                {
                    //haciendo referencia a la conexion de la base de datos
                    Conexion = new SqlConnection(CConexion);
                    //se abre la conexion
                    Conexion.Open();
                    //cadena para poder ingresar un paciente
                    Cadena = "INSERT INTO Servicios VALUES('" + InsertServicio.Nombre_Servicio + "'," + InsertServicio.Precio_Minimo + "," + InsertServicio.Precio_Maximo + "," + InsertServicio.Precio_Actual + ")";
                    //se almacena la cadena y la conexion para poder ejecutarla
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    //se da un formato al comando tipo texto
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    //se ejecuta el comando con ExecuteNonQuery
                    Ejecutar.ExecuteNonQuery();
                    //mensaje que se mostrara en el Cuadro de dialogo.
                    Mensaje = "Servicio Insertado";
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
                Mensaje = "No se pudo Insertar, Servicio Ya Existe";
            }
            //se retorna el mensaje.
            return Mensaje;
        }
        public string UpdateServicio(Servicio_medico Servicio )
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            try
            {
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();
                //cadena para poder ingresar un paciente
                Cadena = "UPDATE Servicios SET Precio_Actual = " + Servicio.Precio_Actual +" WHERE Nombre_Servicio = '" + Servicio.Nombre_Servicio + "'";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Se termino de Modificar el Precio del  Servicio: ";
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
            return Mensaje;
        }
    }
}
