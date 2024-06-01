using Consulta_Hospital.Controladores;
using Consulta_Hospital.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Hospital.Vistas
{
    public partial class Modificar_Especialista : Form
    {
        public Modificar_Especialista()
        {
            InitializeComponent();
            Actualizartabla();
        }

        public void Actualizartabla()
        {
            //se crea una instancia de la clase CEspecialista y se le pone ConsultaPaciente
            CEspecialista ConsultaEspecialista = new CEspecialista();
            //Se crea una instancia de la clase ModeloEspecialista y se le pone ModeloEspecialista
            MEspecialista ModeloEspecialista = new MEspecialista();
            //se llena la tabla DataGridView con la consulta que se realiza a la base de datos....
            ModeloEspecialista.Nombre_Completo = "";
            dataGridView1.DataSource = ConsultaEspecialista.ListarEspecialistas(ModeloEspecialista);
        }



        //Evento para poder editar solo con numeros la columna de telefono...del datagridview
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //se valida que no sea la columna combobox del datagridview
            if (dataGridView1.CurrentCell.ColumnIndex != 4)
            {
                //las columnas se convierten a textbox
                TextBox cell = e.Control as TextBox;
                cell.KeyPress -= new KeyPressEventHandler(this.Columns_KeyPress);
                if (dataGridView1.CurrentCell.ColumnIndex == 2) //Columnas deseadas
                {
                    cell.KeyPress += new KeyPressEventHandler(this.Columns_KeyPress);//se llama al nuevo evento para que solo acepte numeros
                }
            }
        }

        //Evento que solo permite ingresar numeros en la columna Telefono
        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                //Se emplea el begininvoke para que no haya un siclo infinito..
            this.BeginInvoke(new MethodInvoker(() =>
            {
                //Se instancia la clase para Pacientes, esta clase contiene todos los metodos de actualizar, agregar paciente
                CEspecialista ActualizarEspecialista = new CEspecialista();
                //Se instancia la clase que contiene todas las propiedades del Paciente(Datos del paciente) que se utilizan en la base de datos.
                MEspecialista ModeloEspecialista = new MEspecialista();
                //se utilizan todas las propiedades del pacientes de la clase ModeloPaciente
                ModeloEspecialista.Codigo_Especialista= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ModeloEspecialista.Nombre_Completo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ModeloEspecialista.Telefono = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ModeloEspecialista.Correo = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ModeloEspecialista.Especialidad = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //termina el llenado de datos para actualizar 

                    //el metodo ActualizarPaciente.UpdatePaciente(ModeloPaciente,DPIActual) es el encargado de realizar el update de la base de datos...
                    MessageBox.Show(ActualizarEspecialista.UpdateEspecialista(ModeloEspecialista) + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "Cuadro Informativo");
                    //se actualiza el datagridview con los nuevos datos ingresados.
                    Actualizartabla();
            }));
        }
    }
}
