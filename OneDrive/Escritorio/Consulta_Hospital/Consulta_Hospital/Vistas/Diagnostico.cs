using Consulta_Hospital.Controladores;
using Consulta_Hospital.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_Hospital.Vistas
{
    public partial class Diagnostico : Form
    {
        float suma = 0;
        string logeo=string.Empty;
        public Diagnostico()
        {
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            InitializeComponent();
            TBFecha.Text = new System.DateTime(ano, mes, dia, 0, 0, 0, 0).Date.ToShortDateString();
            Servicio_medico servicio = new Servicio_medico();
            CServicio_Medico cServicio=new CServicio_Medico();
            servicio.Nombre_Servicio = "";
            CBServicio.DataSource= cServicio.BuscarServicioN(servicio);
            CBServicio.DisplayMember = "Nombre_Servicio";
            CBServicio.ValueMember = "Nombre_Servicio";
        }

        public void UsuarioLogeado(string userlogeado)
        {
            Usuarios usuarios = new Usuarios();
            CUsuarios cUsuarios = new CUsuarios();
            usuarios.Usuario = userlogeado;
            TBEspecialista.Text = cUsuarios.ConsultaUsuarioporUsuario(usuarios).Rows[0][3].ToString();
            logeo = userlogeado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TBDPI.Text.Equals(""))
            {
                MAgregar_Paciente paciente = new MAgregar_Paciente();
                paciente.DPI = TBDPI.Text;
                CAgregar_Pacientes Cpaciente = new CAgregar_Pacientes();
                if (Cpaciente.ListaPaciente(paciente).Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro el DPI, Por favor Inserta el Paciente", "Cuadro Informativo");
                }
                else
                {
                    TBNPaciente.Text = Cpaciente.ListaPaciente(paciente).Rows[0][1].ToString();
                    TBDPI.ReadOnly= true;
                }

            }
            else
            {
                MessageBox.Show("Campo DPI esta Vacio, Ingrese un DPI", "Cuadro Informativo");
            }
        }

        private void CBTipoDiag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarServicio_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            Servicio_medico servicio = new Servicio_medico();
            CServicio_Medico cServicio = new CServicio_Medico();
            servicio.Nombre_Servicio = CBServicio.Text;
            if (TServicios.Rows.Count>0)
            {
                for (int a=0;a< TServicios.Rows.Count;a++)
                {
                    if (TServicios.Rows[a].Cells[1].Value.ToString().Equals(CBServicio.Text))
                    {
                        bandera = 1;
                    }
                }
                if (bandera==0)
                {
                    suma = suma + (float)Convert.ToDouble(cServicio.BuscarServicioN(servicio).Rows[0][4]);
                    TServicios.Rows.Add(cServicio.BuscarServicioN(servicio).Rows[0].ItemArray);
                    TBPago.Text = suma.ToString();
                }
                else
                {
                    bandera = 0;
                    MessageBox.Show("Servicio ya se encuentra dentro del diagnostico", "Cuadro Informativo");
                }
                
            }
            else
            {
                suma = suma + (float)Convert.ToDouble(cServicio.BuscarServicioN(servicio).Rows[0][4]);
                TServicios.Rows.Add(cServicio.BuscarServicioN(servicio).Rows[0].ItemArray);
                TBPago.Text = suma.ToString();
            }
            
        }

        private void BTRegistrar_Click(object sender, EventArgs e)
        {
            if (!CBTipoDiag.Text.Equals("")&& !TBDPI.Text.Equals("") && !TBReceta.Text.Equals("") && !TBDiagnostico.Text.Equals(""))
            {
                if (TServicios.Rows.Count > 0)
                {
                    MDiagnostico diagnostico1 = new MDiagnostico();
                    CDiagnostico cDiagnostico = new CDiagnostico();
                    Usuarios usuarios = new Usuarios();
                    CUsuarios cUsuarios = new CUsuarios();
                    usuarios.Usuario = logeo;
                    diagnostico1.Tipo_Diagnostico = CBTipoDiag.Text;
                    diagnostico1.Codigo_Especialista = Convert.ToInt32(cUsuarios.Validausuarioexistente(usuarios).Rows[0][3].ToString());
                    diagnostico1.DPI = TBDPI.Text;
                    diagnostico1.Diagnosticos=TBDiagnostico.Text;
                    diagnostico1.Receta=TBReceta.Text;
                    diagnostico1.Fecha_Diagnostico=TBFecha.Text;
                    MessageBox.Show(cDiagnostico.InsertarDiagnostico(TServicios, diagnostico1), "Cuadro Informativo");
                    CBTipoDiag.Text="";
                    TBNPaciente.Text = "";
                    TBDPI.Text="";
                    TBDiagnostico.Text="";
                    TBPago.Text = "0";
                    CBServicio.SelectedIndex=0;
                    TServicios.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("NO SE AGREGO NINGUN SERVICIO", "Cuadro Informativo");
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son Obligatorios", "Cuadro Informativo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBNPaciente.Text = "";
            TBDPI.ReadOnly = false;
            TBDPI.Text = "";
        }

        private void CBServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TServicios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == TServicios.Columns.IndexOf(Eliminar) && e.RowIndex != -1)
            {
                suma = suma - (float)Convert.ToDouble(TServicios.Rows[e.RowIndex].Cells[4].Value.ToString());
                TBPago.Text = suma.ToString();
                TServicios.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
