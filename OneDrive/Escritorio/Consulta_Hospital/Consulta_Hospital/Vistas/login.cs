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
    public partial class login : Form
    {
        public string userio = "";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("")&& !textBox2.Text.Equals(""))
            {
                Usuarios user = new Usuarios();
                CUsuarios cUsuarios = new CUsuarios();
                user.Usuario = textBox1.Text;
                user.Contraseña= textBox2.Text;
                if (cUsuarios.ValidarUsuario(user).Rows.Count > 0)
                {
                    string prueba = cUsuarios.ValidarUsuario(user).Rows[0][4].ToString();
                    if (cUsuarios.ValidarUsuario(user).Rows[0][4].ToString().Equals("1"))
                    {
                        if (cUsuarios.ValidarUsuario(user).Rows[0][5].ToString().Equals("Administrador"))
                        {
                            Principal principal = new Principal();
                            userio = user.Usuario;
                            principal.asignar(userio);
                            this.Hide();
                            principal.ShowDialog();
                            this.Close();
                        }
                        if (cUsuarios.ValidarUsuario(user).Rows[0][5].ToString().Equals("Doctor"))
                        {
                            Principal principal = new Principal();
                            userio = user.Usuario;
                            principal.asignar(userio);
                            principal.subusuarios.Visible=false;
                            principal.citasToolStripMenuItem.Visible = false;
                            principal.pacienteToolStripMenuItem.Visible = false;
                            principal.especialistasToolStripMenuItem.Visible = false;
                            this.Hide();
                            principal.ShowDialog();
                            this.Close();
                        }
                        if (cUsuarios.ValidarUsuario(user).Rows[0][5].ToString().Equals("Enfermera"))
                        {
                            Principal principal = new Principal();
                            userio = user.Usuario;
                            principal.asignar(userio);
                            principal.subusuarios.Visible = false;
                            principal.serviciosToolStripMenuItem.Visible = false;
                            this.Hide();
                            principal.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario esta Inactivo", "Cuadro Informativo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraeña Incorrecto", "Cuadro Informativo");
                }
            }
            else
            {
                MessageBox.Show("Todos los Campos Son Obligatorios", "Cuadro Informativo");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
