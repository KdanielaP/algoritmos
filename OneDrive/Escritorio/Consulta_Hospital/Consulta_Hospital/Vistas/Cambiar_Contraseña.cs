using Consulta_Hospital.Controladores;
using Consulta_Hospital.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Hospital.Vistas
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
            Actualizartabla();
        }

        public void Actualizartabla()
        {
            //se crea una instancia de la clase Usuarios y se le pone Usuarios
            CUsuarios usuarios = new CUsuarios();
            tablaMUser.DataSource = usuarios.ConsultaUsuario();
        }

        private void tablaMUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Se emplea el begininvoke para que no haya un siclo infinito..
            this.BeginInvoke(new MethodInvoker(() =>
            {
                //Se instancia la clase para Pacientes, esta clase contiene todos los metodos de actualizar, agregar paciente
                CUsuarios ActualizarUsuario = new CUsuarios();
                //Se instancia la clase que contiene todas las propiedades del Paciente(Datos del paciente) que se utilizan en la base de datos.
                Usuarios MoUsuario = new Usuarios();
                //se utilizan todas las propiedades del pacientes de la clase ModeloPaciente
                MoUsuario.Codigo_Usuario = int.Parse(tablaMUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                MoUsuario.Contraseña = tablaMUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                MoUsuario.Usuario= tablaMUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (tablaMUser.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Activo"))
                {
                    MoUsuario.Estado_Usuario = 1;
                }

                if (tablaMUser.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("Inactivo"))
                {
                    MoUsuario.Estado_Usuario = 0;
                }
                //termina el llenado de datos para actualizar 
                if (!tablaMUser.Rows[e.RowIndex].Cells[4].Value.ToString().Equals(""))
                {
                    //el metodo ActualizarPaciente.UpdatePaciente(ModeloPaciente,DPIActual) es el encargado de realizar el update de la base de datos...
                    MessageBox.Show(ActualizarUsuario.UpdateUsuario(MoUsuario), "Cuadro Informativo");
                    //se actualiza el datagridview con los nuevos datos ingresados.
                    Actualizartabla();
                }
                else
                {
                    MessageBox.Show("Seleccionar un Estado de Usuario", "Cuadro Informativo");
                }

            }));
        }
    }
}
