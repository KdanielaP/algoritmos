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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Consulta_Hospital.Vistas
{
    public partial class VAgregarPaciente : Form
    {
        public VAgregarPaciente()
        {
            InitializeComponent();
            //se define un tamaño de 13 caracteres
            TDpi.MaxLength = 13;
            //se define un tamaño de 8 caracteres
            Ttelefono.MaxLength = 8;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
        }
        //Evento al darle Click al Boton..
        private void button1_Click(object sender, EventArgs e)
        {
            //se evalua que todos los campos esten llenos
            if (!TDpi.Text.Equals("") && !TNomPac.Text.Equals("") && !TApellidoPaciente.Text.Equals("") && !TDireccion.Text.Equals("") && !TCorreo.Text.Equals("") && !CBSexo.Text.Equals("") && !TEdad.Text.Equals("") && !Ttelefono.Text.Equals("") && !CBTipoSangre.Text.Equals("")&& !CBCorreo.Text.Equals(""))
            {
                MAgregar_Paciente paciente= new MAgregar_Paciente();
                paciente.DPI = TDpi.Text;
                paciente.Nombre_Paciente = TNomPac.Text;
                paciente.Apellido_Paciente = TApellidoPaciente.Text;
                paciente.Edad=int.Parse(TEdad.Text);
                paciente.Sexo=CBSexo.Text;
                paciente.Direccion = TDireccion.Text;
                paciente.Correo = TCorreo.Text+"@"+CBCorreo.Text;
                paciente.Telefono = Ttelefono.Text;
                paciente.Tipo_Sangre = CBTipoSangre.Text;
                CAgregar_Pacientes AgregarPaciente = new CAgregar_Pacientes();
                MessageBox.Show(AgregarPaciente.InsertarPaciente(paciente), "Cuadro Informativo");
                TDpi.Text = "";
                TNomPac.Text = "";
                TApellidoPaciente.Text = "";
                TEdad.Text = "";
                CBSexo.Text = "";
                TDireccion.Text = "";
                TCorreo.Text = "";
                Ttelefono.Text = "";
                CBTipoSangre.Text = "";
                CBCorreo.Text = "";

            }
            else
            {
                //si no se cumple la condicion de que todos los campos esten llenos se muestra un mensaje
                MessageBox.Show("Todos los campos son obligatorios", "Cuadro Informativo");
            }
        }
        //Evento del TextBox TDpi este evento captura las teclas presionadas
        private void TDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se evalua que las teclas presionadas sean digitos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // si se cumple la condicion se escribe en el textbox
                e.Handled = true;
            }
        }
        //Evento del TextBox TTelefono este evento captura las teclas presionadas
        private void Ttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // si se cumple la condicion se escribe en el textbox
                e.Handled = true;
            }
        }
        //Evento del TextBox TEdad este evento captura las teclas presionadas
        private void TEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // si se cumple la condicion se escribe en el textbox
                e.Handled = true;
            }
        }

        private void LimpiarPaciente_Click(object sender, EventArgs e)
        {
            TDpi.Text = "";
            TNomPac.Text = "";
            TApellidoPaciente.Text = "";
            TEdad.Text = "";
            CBSexo.Text = "";
            TDireccion.Text = "";
            TCorreo.Text = "";
            Ttelefono.Text = "";
            CBTipoSangre.Text = "";
            CBCorreo.Text = "";
        }

        private void CBCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TDpi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
