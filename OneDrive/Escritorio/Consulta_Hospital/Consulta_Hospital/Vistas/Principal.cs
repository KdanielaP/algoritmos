using Consulta_Hospital.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consulta_Hospital
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();

        }

        public void asignar(string userio2)
        {
            userlogeado.Text = userio2;
        }
        private void agrearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VAgregarPaciente Fpaciente = new VAgregarPaciente();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitasGenerales CG = new CitasGenerales();
            panel1.Controls.Clear();
            CG.TopLevel = false;
            panel1.Controls.Add(CG);
            CG.Show();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_paciente mpaciente = new modificar_paciente();
            panel1.Controls.Clear();
            mpaciente.TopLevel = false;
            panel1.Controls.Add(mpaciente);
            mpaciente.Show();
        }

        private void especialistasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Especialista aEspecialista = new Agregar_Especialista();
            panel1.Controls.Clear();
            aEspecialista.TopLevel = false;
            panel1.Controls.Add(aEspecialista);
            aEspecialista.Show();
        }

        private void modificarEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Especialista aEspecialista = new Modificar_Especialista();
            panel1.Controls.Clear();
            aEspecialista.TopLevel = false;
            panel1.Controls.Add(aEspecialista);
            aEspecialista.Show();
        }

        private void ingresarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Citas AgregarCita = new Agregar_Citas();
            panel1.Controls.Clear();
            AgregarCita.TopLevel = false;
            panel1.Controls.Add(AgregarCita);
            AgregarCita.Show();
        }

        private void agregarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Servicio Servicios = new Agregar_Servicio();
            panel1.Controls.Clear();
            Servicios.TopLevel = false;
            panel1.Controls.Add(Servicios);
            Servicios.Show();
        }

        private void modificarPreciosDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_Precio_servicio Servicios = new Actualizar_Precio_servicio();
            panel1.Controls.Clear();
            Servicios.TopLevel = false;
            panel1.Controls.Add(Servicios);
            Servicios.Show();
        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagnostico Diag = new Diagnostico();
            Diag.UsuarioLogeado(userlogeado.Text);
            panel1.Controls.Clear();
            Diag.TopLevel = false;
            panel1.Controls.Add(Diag);
            Diag.Show();
        }

        private void porPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Usuario VUsuario = new Agregar_Usuario();
            panel1.Controls.Clear();
            VUsuario.TopLevel = false;
            panel1.Controls.Add(VUsuario);
            VUsuario.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_Contraseña VUsuario = new Cambiar_Contraseña();
            panel1.Controls.Clear();
            VUsuario.TopLevel = false;
            panel1.Controls.Add(VUsuario);
            VUsuario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login ();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial ();
            panel1.Controls.Clear();
            historial.TopLevel = false;
            panel1.Controls.Add(historial);
            historial.Show();
        }
    }
}
