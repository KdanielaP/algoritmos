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
    public partial class Agregar_Servicio : Form
    {
        public Agregar_Servicio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == '.' && ((sender as TextBox).Text.Equals("")))
                    {
                        (sender as TextBox).Text = "0" + e.KeyChar;
                        (sender as TextBox).Select((sender as TextBox).Text.Length, 0);
                        e.Handled = true;
                    }
                    else
                    {
                        int len = (sender as TextBox).Text.Length;
                        int count = 0;
                        bool point = false;
                        for (int i = 0; i != len; ++i)
                        {
                            ++count;
                            if ((sender as TextBox).Text[i] == '.' && (sender as TextBox).SelectionStart > i && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
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
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            puntodecimal(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            puntodecimal(sender, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            puntodecimal(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                if ((float)Convert.ToDouble(textBox4.Text) <= (float)Convert.ToDouble(textBox3.Text))
                {
                    if ((float)Convert.ToDouble(textBox4.Text) >= (float)Convert.ToDouble(textBox2.Text))
                    {
                        Servicio_medico Servicios = new Servicio_medico();
                        CServicio_Medico CServicios = new CServicio_Medico();
                        Servicios.Nombre_Servicio = textBox1.Text;
                        Servicios.Precio_Minimo = (float)Convert.ToDouble(textBox2.Text);
                        Servicios.Precio_Maximo = (float)Convert.ToDouble(textBox3.Text);
                        Servicios.Precio_Actual = (float)Convert.ToDouble(textBox4.Text);
                        MessageBox.Show(CServicios.InsertarServicio(Servicios), "Cuadro Informativo");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Precio Inicial debe de ser igual o Mayor al precio minimo", "Cuadro Informativo");
                        textBox4.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El Precio Inicial debe de ser igual o menor al precio maximo", "Cuadro Informativo");
                    textBox4.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son Obligatorios", "Cuadro Informativo");
            }
            
        }
    }
}
