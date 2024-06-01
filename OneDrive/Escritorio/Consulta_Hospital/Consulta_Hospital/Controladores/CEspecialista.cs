using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Consulta_Hospital.Modelos;

namespace Consulta_Hospital.Controladores
{
    public class CEspecialista
    {
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;

        public CEspecialista()
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        public DataTable ListarEspecialistas(MEspecialista InforEspecialista)
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
                if (!InforEspecialista.Nombre_Completo.Equals(""))
                {
                    //si DPI contiene algun caracter busca el paciente por medio del DPI
                    Cadena = "select * from Especialistas where Nombre_Completo='" + InforEspecialista.Nombre_Completo + "'";
                }
                else
                {
                    //si DPI No contiene nada se realiza una consulta General.
                    Cadena = "select * from Especialistas";
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

        public DataTable ListarEspecialistas2(MEspecialista InforEspecialista)
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
                //si DPI contiene algun caracter busca el paciente por medio del DPI
                Cadena = "select * from Especialistas where Especialidad='" + InforEspecialista.Especialidad + "'";
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

        public string InsertarEspecialista(MEspecialista InsertEspecialista)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            if (ListarEspecialistas(InsertEspecialista).Rows.Count == 0)
            {
                try
                {
                    //haciendo referencia a la conexion de la base de datos
                    Conexion = new SqlConnection(CConexion);
                    //se abre la conexion
                    Conexion.Open();
                    //cadena para poder ingresar un paciente
                    Cadena = "INSERT INTO Especialistas VALUES('" + InsertEspecialista.Nombre_Completo + "'," + InsertEspecialista.Telefono + ",'" + InsertEspecialista.Correo + "','" + InsertEspecialista.Especialidad + "')";
                    //se almacena la cadena y la conexion para poder ejecutarla
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    //se da un formato al comando tipo texto
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    //se ejecuta el comando con ExecuteNonQuery
                    Ejecutar.ExecuteNonQuery();
                    //mensaje que se mostrara en el Cuadro de dialogo.
                    Mensaje = "Especialista Insertado";
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
                Mensaje = "No se pudo Insertar, Especialista Ya Existe";
            }
            //se retorna el mensaje.
            return Mensaje;
        }

        public string UpdateEspecialista(MEspecialista InsertPaciente)
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
                Cadena = "UPDATE Especialistas SET Nombre_Completo = '" + InsertPaciente.Nombre_Completo + "',Telefono = " + InsertPaciente.Telefono + ",Correo = '" + InsertPaciente.Correo + "',Especialidad = '" + InsertPaciente.Especialidad + "' WHERE Codigo_Especialista = " + InsertPaciente.Codigo_Especialista+"";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Se termino de Modificar el Especialista con Nombre: ";
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
