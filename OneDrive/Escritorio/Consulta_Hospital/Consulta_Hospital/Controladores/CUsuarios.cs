using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Hospital.Modelos;
using System.Reflection;
using System.CodeDom.Compiler;

namespace Consulta_Hospital.Controladores
{

    public class CUsuarios
    {
        //referencia a una nueva tabla sin instanciar
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;

        public CUsuarios()
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        public DataTable ValidarUsuario(Usuarios usuario)
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();

                Cadena = "select * from Usuarios where Usuario='" + usuario.Usuario + "' and Contraseña='" + usuario.Contraseña + "'";
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


        public DataTable Validausuarioexistente(Usuarios usuario)
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();

                Cadena = "select * from Usuarios where Usuario='" + usuario.Usuario + "'";
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

        public string InsertarCita(Usuarios InsertUsuario)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            if (Validausuarioexistente(InsertUsuario).Rows.Count == 0)
            {
                try
                {
                    //haciendo referencia a la conexion de la base de datos
                    Conexion = new SqlConnection(CConexion);
                    //se abre la conexion
                    Conexion.Open();
                    //cadena para poder ingresar un paciente
                    Cadena = "INSERT INTO Usuarios VALUES('" + InsertUsuario.Usuario + "','" + InsertUsuario.Contraseña + "'," + InsertUsuario.Codigo_Especialista + "," + InsertUsuario.Estado_Usuario + ",'" + InsertUsuario.Rol + "')";
                    //se almacena la cadena y la conexion para poder ejecutarla
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    //se da un formato al comando tipo texto
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    //se ejecuta el comando con ExecuteNonQuery
                    Ejecutar.ExecuteNonQuery();
                    //mensaje que se mostrara en el Cuadro de dialogo.
                    Mensaje = "Usuario Insertado";
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
                Mensaje = "Ya Existe un usuario, por favor asigne otro usuario";
            }
            //se retorna el mensaje.
            return Mensaje;
        }

        public DataTable ConsultaUsuario()
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();

                Cadena = "select u.Codigo_Usuario, u.Usuario, u.Contraseña, e.Nombre_Completo, " +
                    "case u.Estado_Usuario when 1 then 'Activo'" +
                    "when 0 then 'Inactivo' end as Estado_Usuario,u.Rol from Usuarios u " +
                    "inner join Especialistas e on e.Codigo_Especialista = u.Codigo_Especialista";
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

        public string UpdateUsuario(Usuarios Usuario1)
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
                Cadena = "UPDATE Usuarios SET Usuario='" + Usuario1.Usuario + "', Contraseña = '" + Usuario1.Contraseña + "', Estado_Usuario="+ Usuario1.Estado_Usuario+" WHERE Codigo_Usuario = " + Usuario1.Codigo_Usuario + "";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Se termino de Modificar el Usuario: "+Usuario1.Usuario;
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

        public DataTable ConsultaUsuarioporUsuario(Usuarios usuario)
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(CConexion);
                //se abre la conexion
                Conexion.Open();

                Cadena = "select u.Codigo_Usuario, u.Usuario, u.Contraseña, e.Nombre_Completo, " +
                    "case u.Estado_Usuario when 1 then 'Activo'" +
                    "when 0 then 'Inactivo' end as Estado_Usuario,u.Rol from Usuarios u " +
                    "inner join Especialistas e on e.Codigo_Especialista = u.Codigo_Especialista where u.Usuario='" + usuario.Usuario+"'"; 
                    
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

