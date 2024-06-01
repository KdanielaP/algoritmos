using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta_Hospital.Controladores;
using Consulta_Hospital.Modelos;

namespace Consulta_Hospital.Vistas
{
    public partial class modificar_paciente : Form
    {
        string DPIActual = string.Empty;
        //Constructor
        public modificar_paciente()
        {
            //Inicia todos los componentes que se colocaron en la vista
            InitializeComponent();

            //este metodo actualiza la tabla de la vista, no la de la base de datos..
            Actualizartabla();

        }
    

        //Metodo para llenar la tabla de la vista el datagridview, no es el de la base de datos....
        public void Actualizartabla()
        {
            //se crea una instancia de la clase CAgregar_Pacientes y se le pone ConsultaPaciente
            CAgregar_Pacientes ConsultaPaciente = new CAgregar_Pacientes();
            //Se crea una instancia de la clase ModeloPaciente y se le pone ModeloPaciente
            MAgregar_Paciente ModeloPaciente = new MAgregar_Paciente();
            //se utiliza la propiedades de la clase ModeloPaciente
            ModeloPaciente.DPI = "";
            //se llena la tabla DataGridView con la consulta que se realiza a la base de datos....
            dataGridView1.DataSource = ConsultaPaciente.ListaPaciente(ModeloPaciente);
        }

        //Evento que actualiza la base de datos cuando se edita una columna de la tabla DataGridView
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Se emplea el begininvoke para que no haya un siclo infinito..
            this.BeginInvoke(new MethodInvoker(() =>
            {
                //Se instancia la clase para Pacientes, esta clase contiene todos los metodos de actualizar, agregar paciente
                CAgregar_Pacientes ActualizarPaciente = new CAgregar_Pacientes();
                //Se instancia la clase que contiene todas las propiedades del Paciente(Datos del paciente) que se utilizan en la base de datos.
                MAgregar_Paciente ModeloPaciente = new MAgregar_Paciente();
                //se utilizan todas las propiedades del pacientes de la clase ModeloPaciente
                ModeloPaciente.DPI = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ModeloPaciente.Nombre_Paciente = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ModeloPaciente.Apellido_Paciente = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ModeloPaciente.Edad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                ModeloPaciente.Sexo = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                ModeloPaciente.Telefono = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ModeloPaciente.Direccion = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                ModeloPaciente.Correo = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                ModeloPaciente.Tipo_Sangre = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //termina el llenado de datos para actualizar 

                //el metodo ActualizarPaciente.UpdatePaciente(ModeloPaciente,DPIActual) es el encargado de realizar el update de la base de datos...
                MessageBox.Show(ActualizarPaciente.UpdatePaciente(ModeloPaciente,DPIActual)+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), "Cuadro Informativo");
                //se actualiza el datagridview con los nuevos datos ingresados.
                Actualizartabla();
            }));
        }

        //este metodo se utiliza para determinar si el DPI cambia el evento es cuando se empieza a editar una celda de la tabla
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //se valida que se la columna 0 que es la columna del DPI
            if(e.ColumnIndex == 0)
            {
                //se asigna el valor que se tiene actualmente del DPI antes de cambiarlo, con el fin de modificar la fila correcta en la base de datos
                DPIActual = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }else
            {
                //Si no se cambia el DPI no se realiza ningun cambio.
                DPIActual = "";
            }

        }

        //Evento para poder editar solo con numeros la columna de telefono...del datagridview
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //se valida que no sea la columna combobox del datagridview
            if (dataGridView1.CurrentCell.ColumnIndex != 4 && dataGridView1.CurrentCell.ColumnIndex != 8)
            {
                //las columnas se convierten a textbox
                TextBox cell = e.Control as TextBox;
                cell.KeyPress -= new KeyPressEventHandler(this.Columns_KeyPress);
                if (dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 5 || dataGridView1.CurrentCell.ColumnIndex == 0) //Columnas deseadas
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
    }
}
