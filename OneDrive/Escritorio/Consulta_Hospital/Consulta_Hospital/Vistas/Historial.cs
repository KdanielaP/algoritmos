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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
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
                    panel1.Controls.Clear();
                    TBNPaciente.Text = Cpaciente.ListaPaciente(paciente).Rows[0][1].ToString();
                    TBDPI.ReadOnly = true;
                    metodo();
                }

            }
            else
            {
                MessageBox.Show("Campo DPI esta Vacio, Ingrese un DPI", "Cuadro Informativo");
            }
        }

        public void metodo()
        {
            if (TBNPaciente.TextLength != 0)
            {
                int x = 10;
                int y = 5;
                Font replacementFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                DataTable dt = new DataTable();
                MDiagnostico dpi = new MDiagnostico();
                dpi.DPI = TBDPI.Text;
                Reportes reportes = new Reportes();
                dt = reportes.Historial(dpi).Copy();
                if (dt.Rows.Count > 0)
                {
                    Label[,] etiquetas = new Label[dt.Rows.Count, 4];//matriz de N fila * 5 columnas;
                    TextBox[,] Mostrar = new TextBox[dt.Rows.Count, 4];//matriz de N fila * 5 columnas;
                    for (int t = 0; t < dt.Rows.Count; t++)
                    {
                        //etiqueta y texbox 1
                        etiquetas[t, 0] = new Label();
                        Mostrar[t, 0] = new TextBox();
                        etiquetas[t, 0].AutoSize = true;//se coloca que la tabla se ajuste al contenido
                        Mostrar[t, 0].BorderStyle = BorderStyle.FixedSingle;
                        etiquetas[t, 0].Font = replacementFont;// se utiliza la variable para pode definir el tipo de letra, estilo de letra y en negrita.
                        etiquetas[t, 0].Location = new System.Drawing.Point(x, y);//posicion del label
                        Mostrar[t, 0].Location = new System.Drawing.Point(x, y + etiquetas[t, 0].Height);
                        etiquetas[t, 0].Text = "Fecha Diagnostico";//se coloca el nombre del especialita en el label
                        Mostrar[t, 0].Size = new System.Drawing.Size(etiquetas[t, 0].Width, 20);
                        Mostrar[t, 0].ReadOnly = true;
                        Mostrar[t, 0].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        Mostrar[t, 0].Text = dt.Rows[t][0].ToString();
                        x = x + etiquetas[t, 0].Width;//se suma 215 de la posicion de la tabla y del array esto se utiliza para que no se muestre el label y la tabla en la misma posicion
                        etiquetas[t, 0].Show();//se muestra el array
                        Mostrar[t, 0].Show();
                        panel1.Controls.Add(etiquetas[t, 0]);//se agrega al panel
                        panel1.Controls.Add(Mostrar[t, 0]);
                        //fin de etiqueta y texbox 1

                        //etiqueta y texbox 2
                        etiquetas[t, 1] = new Label();
                        Mostrar[t, 1] = new TextBox();
                        etiquetas[t, 1].AutoSize = true;//se coloca que la tabla se ajuste al contenido
                        Mostrar[t, 1].BorderStyle = BorderStyle.FixedSingle;
                        etiquetas[t, 1].Font = replacementFont;// se utiliza la variable para pode definir el tipo de letra, estilo de letra y en negrita.
                        etiquetas[t, 1].Location = new System.Drawing.Point(x + (etiquetas[t, 1].Width / 2), y);//posicion del label
                        Mostrar[t, 1].Location = new System.Drawing.Point(x + (etiquetas[t, 1].Width / 2), y + etiquetas[t, 1].Height);
                        etiquetas[t, 1].Text = "Especialista";//se coloca el nombre del especialita en el label
                        Mostrar[t, 1].Size = new System.Drawing.Size(etiquetas[t, 1].Width, 20);
                        Mostrar[t, 1].ReadOnly = true;
                        Mostrar[t, 1].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        Mostrar[t, 1].Text = dt.Rows[t][1].ToString();
                        x = x + etiquetas[t, 1].Width + 20;//se suma 215 de la posicion de la tabla y del array esto se utiliza para que no se muestre el label y la tabla en la misma posicion
                        etiquetas[t, 1].Show();//se muestra el array
                        Mostrar[t, 1].Show();
                        panel1.Controls.Add(etiquetas[t, 1]);//se agrega al panel
                        panel1.Controls.Add(Mostrar[t, 1]);
                        //final etiqueta y texbox 2

                        //etiqueta y texbox 3
                        etiquetas[t, 2] = new Label();
                        Mostrar[t, 2] = new TextBox();
                        etiquetas[t, 2].AutoSize = true;//se coloca que la tabla se ajuste al contenido
                        Mostrar[t, 2].BorderStyle = BorderStyle.FixedSingle;
                        etiquetas[t, 2].Font = replacementFont;// se utiliza la variable para pode definir el tipo de letra, estilo de letra y en negrita.
                        etiquetas[t, 2].Location = new System.Drawing.Point(x + (etiquetas[t, 2].Width / 2), y);//posicion del label
                        Mostrar[t, 2].Location = new System.Drawing.Point(x + (etiquetas[t, 2].Width / 2), y + etiquetas[t, 2].Height);
                        etiquetas[t, 2].Text = "Especialidad";//se coloca el nombre del especialita en el label
                        Mostrar[t, 2].Size = new System.Drawing.Size(etiquetas[t, 2].Width, 20);
                        Mostrar[t, 2].ReadOnly = true;
                        Mostrar[t, 2].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        Mostrar[t, 2].Text = dt.Rows[t][2].ToString();
                        x = x + etiquetas[t, 2].Width + 20;//se suma 215 de la posicion de la tabla y del array esto se utiliza para que no se muestre el label y la tabla en la misma posicion
                        etiquetas[t, 2].Show();//se muestra el array
                        Mostrar[t, 2].Show();
                        panel1.Controls.Add(etiquetas[t, 2]);//se agrega al panel
                        panel1.Controls.Add(Mostrar[t, 2]);
                        //final etiqueta y texbox 3

                        //etiqueta y texbox 4
                        etiquetas[t, 3] = new Label();
                        Mostrar[t, 3] = new TextBox();
                        etiquetas[t, 3].AutoSize = true;//se coloca que la tabla se ajuste al contenido
                        Mostrar[t, 3].BorderStyle = BorderStyle.FixedSingle;
                        etiquetas[t, 3].Font = replacementFont;// se utiliza la variable para pode definir el tipo de letra, estilo de letra y en negrita.
                        etiquetas[t, 3].Location = new System.Drawing.Point(x + (etiquetas[t, 3].Width / 2), y);//posicion del label
                        Mostrar[t, 3].Location = new System.Drawing.Point(x + (etiquetas[t, 3].Width / 2), y + etiquetas[t, 3].Height);
                        etiquetas[t, 3].Text = "Diagnostico";//se coloca el nombre del especialita en el label
                        Mostrar[t, 3].Size = new System.Drawing.Size(250, 20);
                        Mostrar[t, 3].ReadOnly = true;
                        Mostrar[t, 3].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        Mostrar[t, 3].Text = dt.Rows[t][3].ToString();
                        y = y + etiquetas[t, 0].Height + Mostrar[t, 0].Height + 15;
                        x = 10;
                        etiquetas[t, 3].Show();//se muestra el array
                        Mostrar[t, 3].Show();
                        panel1.Controls.Add(etiquetas[t, 3]);//se agrega al panel
                        panel1.Controls.Add(Mostrar[t, 3]);
                        //final etiqueta y texbox 4
                    }
                    MessageBox.Show("Consulta Realizada", "Cuadro Informativo");
                }
                else
                {
                    MessageBox.Show("No se tiene ningun Diagnostico", "Cuadro Informativo");
                }

            }
        }

        private void TBNPaciente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBNPaciente.Text = "";
            TBDPI.Text = "";
            TBDPI.ReadOnly= false;
            panel1.Controls.Clear();
        }
    }
}
