using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta_Hospital.Modelos;
using System.Windows.Forms;

namespace Consulta_Hospital.Controladores
{
    public class CDiagnostico
    {
        //variables sql
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        string CConexion = string.Empty;
        public CDiagnostico() 
        {
            //cadena de conexion para la base de datos.
            CConexion = "Server=KATHERINE; DataBase=Consulta_Medica; Integrated security=true";
        }

        public string InsertarDiagnostico(DataGridView detalle, MDiagnostico diagnostico)
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
                Cadena = "INSERT INTO Diagnosticos VALUES('" + diagnostico.Tipo_Diagnostico + "'," + diagnostico.Codigo_Especialista + ",'" + diagnostico.DPI + "','" + diagnostico.Diagnosticos + "','" + diagnostico.Receta + "','" + diagnostico.Fecha_Diagnostico + "');" +
                    "select SCOPE_IDENTITY();";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                int codigo = Convert.ToInt32(Ejecutar.ExecuteScalar());
                for (int t=0; t<detalle.Rows.Count;t++)
                {
                    Cadena = "Insert Into Detalle_Diagnostico values ( "+codigo+"," + detalle.Rows[t].Cells[0].Value.ToString() + "," + detalle.Rows[t].Cells[4].Value.ToString() + ")";
                    Ejecutar = new SqlCommand(Cadena, Conexion);
                    Ejecutar.CommandType = System.Data.CommandType.Text;
                    Ejecutar.ExecuteNonQuery();
                }
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Diagnostico Creado";
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
            //se retorna el mensaje.
            return Mensaje;
        }
    }
}
