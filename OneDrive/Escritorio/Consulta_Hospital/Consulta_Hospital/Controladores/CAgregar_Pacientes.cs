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
    public class CAgregar_Pacientes
    {
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;

        //constructor de la clase
        public CAgregar_Pacientes()
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        //funcion que devuelve todos los Pacientes, devolvera una tabla y recibe un parametro de tipo MAgregar_Paciente
        public DataTable ListaPaciente(MAgregar_Paciente InforPaciente)
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
                if (!InforPaciente.DPI.Equals(""))
                {
                    //si DPI contiene algun caracter busca el paciente por medio del DPI
                    Cadena = "select * from Pacientes where DPI= '"+ InforPaciente.DPI+"'";
                }
                else
                {
                    //si DPI No contiene nada se realiza una consulta General.
                    Cadena = "select * from Pacientes";
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

        public string InsertarPaciente(MAgregar_Paciente InsertPaciente)
        {
            string Cadena = string.Empty;
            string Mensaje= string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            if (ListaPaciente(InsertPaciente).Rows.Count==0)
            {
                try
                {
                    //haciendo referencia a la conexion de la base de datos
                    Conexion = new SqlConnection(CConexion);
                    //se abre la conexion
                    Conexion.Open();
                    //cadena para poder ingresar un paciente
                    Cadena = "INSERT INTO Pacientes (DPI,Nombre_Paciente,Apellido_Paciente,Edad,Sexo,Telefono,Direccion,Correo,Tipo_Sangre) VALUES('"+InsertPaciente.DPI+"','"+ InsertPaciente.Nombre_Paciente + "','"+InsertPaciente.Apellido_Paciente+ "',"+InsertPaciente.Edad + ",'"+InsertPaciente.Sexo+"','"+InsertPaciente.Telefono+"','"+ InsertPaciente.Direccion + "','"+ InsertPaciente.Correo + "','"+ InsertPaciente.Tipo_Sangre + "')";
                    //se almacena la cadena y la conexion para poder ejecutarla
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    //se da un formato al comando tipo texto
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    //se ejecuta el comando con ExecuteNonQuery
                    Ejecutar.ExecuteNonQuery();
                    //mensaje que se mostrara en el Cuadro de dialogo.
                    Mensaje = "Paciente Insertado";
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
                Mensaje = "No se pudo Insertar, Paciente Ya Existe";
            }
            //se retorna el mensaje.
            return Mensaje;
        }

        public string UpdatePaciente(MAgregar_Paciente InsertPaciente, string DPIActual)
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
                    if(!DPIActual.Equals(""))
                    {
                        Cadena = "UPDATE Pacientes SET DPI = '" + InsertPaciente.DPI + "',Nombre_Paciente = '" + InsertPaciente.Nombre_Paciente + "',Apellido_Paciente = '" + InsertPaciente.Apellido_Paciente + "',Edad = " + InsertPaciente.Edad + ",Sexo = '" + InsertPaciente.Sexo + "',Telefono ='" + InsertPaciente.Telefono + "',Direccion ='" + InsertPaciente.Direccion + "' ,Correo = '" + InsertPaciente.Correo + "',Tipo_Sangre = '" + InsertPaciente.Tipo_Sangre + "' WHERE DPI = '" + DPIActual + "'";
                        //se almacena la cadena y la conexion para poder ejecutarla
                        Ejecutar = new SqlCommand(Cadena, Conexion);
                        //se da un formato al comando tipo texto
                        Ejecutar.CommandType = System.Data.CommandType.Text;
                        //se ejecuta el comando con ExecuteNonQuery
                        Ejecutar.ExecuteNonQuery();
                        //mensaje que se mostrara en el Cuadro de dialogo.
                        Mensaje = "Se termino de Modificar el Paciente con Numero de DPI: ";
                    }else
                    {
                        Cadena = "UPDATE Pacientes SET DPI = '" + InsertPaciente.DPI + "',Nombre_Paciente = '" + InsertPaciente.Nombre_Paciente + "',Apellido_Paciente = '" + InsertPaciente.Apellido_Paciente + "',Edad = " + InsertPaciente.Edad + ",Sexo = '" + InsertPaciente.Sexo + "',Telefono ='" + InsertPaciente.Telefono + "',Direccion ='" + InsertPaciente.Direccion + "' ,Correo = '" + InsertPaciente.Correo + "',Tipo_Sangre = '" + InsertPaciente.Tipo_Sangre + "' WHERE DPI = '" + InsertPaciente.DPI + "'";
                        //se almacena la cadena y la conexion para poder ejecutarla
                        Ejecutar = new SqlCommand(Cadena, Conexion);
                        //se da un formato al comando tipo texto
                        Ejecutar.CommandType = System.Data.CommandType.Text;
                        //se ejecuta el comando con ExecuteNonQuery
                        Ejecutar.ExecuteNonQuery();
                        //mensaje que se mostrara en el Cuadro de dialogo.
                        Mensaje = "Se termino de Modificar el Paciente con Numero de DPI: ";
                    }
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
