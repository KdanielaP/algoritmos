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
    public partial class Actualizar_Precio_servicio : Form
    {

        CServicio_Medico servicio_Medico = new CServicio_Medico();
        Servicio_medico Servicio = new Servicio_medico();
        DataTable dt = new DataTable();

        public Actualizar_Precio_servicio()
        {

            InitializeComponent();
            Servicio.Nombre_Servicio = "";
            dt = servicio_Medico.BuscarServicioN(Servicio).Copy();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Nombre_Servicio";
            comboBox1.SelectedIndex = 0;
            textBox1.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox2.Text = dt.Rows[0][4].ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!comboBox1.DisplayMember.Equals(""))
            {
                Servicio.Nombre_Servicio = comboBox1.Text;
                dt = servicio_Medico.BuscarServicioN(Servicio).Copy();
                textBox1.Text = dt.Rows[0][2].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox2.Text = dt.Rows[0][4].ToString();
            }
            
        }

        public void puntodecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                // solo 1 punto decimal
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == '.' && ((sender as System.Windows.Forms.TextBox).Text.Equals("")))
                    {
                        (sender as System.Windows.Forms.TextBox).Text = "0" + e.KeyChar;
                        (sender as System.Windows.Forms.TextBox).Select((sender as System.Windows.Forms.TextBox).Text.Length, 0);
                        e.Handled = true;
                    }
                    else
                    {
                        int len = (sender as System.Windows.Forms.TextBox).Text.Length;
                        int count = 0;
                        bool point = false;
                        for (int i = 0; i != len; ++i)
                        {
                            ++count;
                            if ((sender as System.Windows.Forms.TextBox).Text[i] == '.' && (sender as System.Windows.Forms.TextBox).SelectionStart > i && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                            {
                                count = 0;
                                point = true;
                            }
                            else if ((point && count > 1))
                            {
                                e.Handled = true;
                                MessageBox.Show("No se acepta mas de 2 decimales", "Cuadro Informativo");
                            }
                        }
                    }
                }
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            puntodecimal(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((float)Convert.ToDouble(textBox3.Text) <= (float)Convert.ToDouble(textBox4.Text))
            {
                if ((float)Convert.ToDouble(textBox3.Text) >= (float)Convert.ToDouble(textBox1.Text))
                {
                    if ((float)Convert.ToDouble(textBox3.Text) == (float)Convert.ToDouble(textBox2.Text))
                    {
                        MessageBox.Show("El Precio Nuevo debe de ser distinto al precio Actual", "Cuadro Informativo");
                        textBox3.Text = "";
                    }
                    else
                    {
                        Servicio.Nombre_Servicio = comboBox1.Text;
                        Servicio.Precio_Actual = (float)Convert.ToDouble(textBox3.Text);
                        MessageBox.Show(servicio_Medico.UpdateServicio(Servicio), "Cuadro Informativo");
                        textBox3.Text = "";
                        comboBox1.SelectedIndex= 0; 
                    }
                }
                else
                {
                    MessageBox.Show("El Precio Nuevo debe de ser igual o Mayor al precio minimo", "Cuadro Informativo");
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El Precio Nuevo debe de ser igual o menor al precio maximo", "Cuadro Informativo");
                textBox3.Text = "";
            }
        }

        private void Actualizar_Precio_servicio_Load(object sender, EventArgs e)
        {

        }
    }
}
