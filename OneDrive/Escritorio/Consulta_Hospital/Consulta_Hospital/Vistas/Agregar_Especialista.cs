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
    public partial class Agregar_Especialista : Form
    {
        public Agregar_Especialista()
        {
            InitializeComponent();
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se evalua que las teclas presionadas sean digitos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // si se cumple la condicion se escribe en el textbox
                e.Handled = true;
            }
        }

        private void LimpiarPaciente_Click(object sender, EventArgs e)
        {
            TBNC.Text = "";
            TBTelefono.Text = "";
            TBCE.Text = "";
            CBEs.Text = "";
            CBCE.Text = "";
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            if (!TBCE.Text.Equals("")&& !TBTelefono.Text.Equals("")&& !TBCE.Text.Equals("")&& !CBCE.Text.Equals("")&& !CBEs.Text.Equals(""))
            {
                MEspecialista Especialista= new MEspecialista();
                CEspecialista cEspecialista= new CEspecialista();
                Especialista.Nombre_Completo= TBNC.Text;
                Especialista.Telefono = TBTelefono.Text;
                Especialista.Correo= TBCE.Text+"@"+CBCE.Text;
                Especialista.Especialidad=CBEs.Text;
                MessageBox.Show(cEspecialista.InsertarEspecialista(Especialista), "Cuadro Informativo");
                TBNC.Text = "";
                TBTelefono.Text = "";
                TBCE.Text = "";
                CBEs.Text = "";
                CBCE.Text = "";
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Cuadro Informativo");
            }
        }

        private void Agregar_Especialista_Load(object sender, EventArgs e)
        {

        }
    }
}
