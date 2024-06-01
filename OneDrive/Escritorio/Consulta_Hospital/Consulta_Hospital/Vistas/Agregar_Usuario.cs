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
    public partial class Agregar_Usuario : Form
    {
        DataTable dt = new DataTable();
        public Agregar_Usuario()
        {        
            InitializeComponent();
            MEspecialista especialista = new MEspecialista();
            CEspecialista especialista1 = new CEspecialista();
            especialista.Nombre_Completo = "";
            dt = especialista1.ListarEspecialistas(especialista);
            //se coloca la tabla al combo box
            CBEspecialista.DataSource = dt;
            //se coloca el nombre del diplay
            CBEspecialista.DisplayMember = "Nombre_Completo";
            //se coloca el valor de la columna
            CBEspecialista.ValueMember = "Nombre_Completo";
        }

        private void LUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Usuarios user =new Usuarios();
            CUsuarios Cuser =  new CUsuarios();
            if (!TBUsuario.Text.Equals("") && !TBcontraseña.Text.Equals("") && !CBRol.Text.Equals(""))
            {
                Usuarios usuarios = new Usuarios();
                CUsuarios cUsuarios = new CUsuarios();
                usuarios.Usuario = TBUsuario.Text;
                usuarios.Contraseña = TBcontraseña.Text;
                usuarios.Codigo_Especialista = (int)dt.Rows[CBEspecialista.SelectedIndex][0];
                usuarios.Rol = CBRol.Text;
                usuarios.Estado_Usuario = 1;
                MessageBox.Show(cUsuarios.InsertarCita(usuarios), "Cuadro Informativo");
                TBUsuario.Text = "";
                TBcontraseña.Text = "";
                CBEspecialista.SelectedIndex = 0;
                CBRol.Text="";
            }
            else
            {
                MessageBox.Show("Todos los Campos son Obligatorios", "Cuadro Informativo");
            }
        }
    }
}
