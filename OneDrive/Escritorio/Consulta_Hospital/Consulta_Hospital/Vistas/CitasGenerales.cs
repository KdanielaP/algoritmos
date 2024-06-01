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
using System.Xml.Linq;

namespace Consulta_Hospital.Vistas
{
    public partial class CitasGenerales : Form
    {
        DataTable dt =new DataTable();
        public CitasGenerales()
        {
            InitializeComponent();
            MCita mCita = new MCita();// se instancia la clase MCita del apartado de Modelos
            //se coloca el estilo de letra, tipo y negrita
            Font replacementFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Reportes reportes = new Reportes();//se instancia la clase Reportes del apartado Controladores
            mCita.Fecha = dateTimePicker1.Value.Date.ToShortDateString();// se coloca la fecha que se haya seleccionado, si se selecciona Citas en el menu carga la fecha actual.
            dt = reportes.HorarioGeneral(mCita).Copy();// se copia la tabla que se genera con la consulta de reportes
            //se manda a llamar el metodo crearvista() para generar los label y las tablas de las citas del día seleccionado
            if (dt.Rows.Count != 0)
                crearvista();
        }

        public void crearvista()
        {
            int x = 0;//variable para colocar los label y las tablas en una posicion del panel
            int y = 0;//y es una bandera que utilizamos para saber si ya se tiene un doctor
            int posicion = 0;//variable que se utiliza para almacenar la posicion si ya existe una etiqueta con el doctor y asi agregar una hora y nombre de paciente en la tabla
            MCita mCita = new MCita();// se instancia la clase MCita del apartado de Modelos
            //se coloca el estilo de letra, tipo y negrita
            Font replacementFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Reportes reportes = new Reportes();//se instancia la clase Reportes del apartado Controladores
            mCita.Fecha = dateTimePicker1.Value.Date.ToShortDateString();// se coloca la fecha que se haya seleccionado, si se selecciona Citas en el menu carga la fecha actual.
            dt = reportes.HorarioGeneral(mCita).Copy();// se copia la tabla que se genera con la consulta de reportes
            if (dt.Rows.Count!=0)//se valida que tenga la tabla no este vacia, si la tabla esta vacia nos indica que no se tiene ninguna Cita con la fecha almacena anteriormente.
            {
                Label[] labelarray = new Label[dt.Rows.Count];//se crea un arreglo de label, esto nos permite almacenar los nombres de los especialistas en un label, esto es un dato que nos devolvio
                //la clase de Reporte

                DataTable dttemporal = new DataTable();//se crea una tabla temporal
                dttemporal = dt.Copy();//se copia la tabla de los resultados de la consulta de la clase reporte 
                dttemporal.Columns.Remove("Especialista");//se elimina la columna especialista, la columna se elimina ya que se almaceno en el arreglo de label el nombre del especialista
                dttemporal.Columns.Remove("Fecha");//se elimina la columna fecha, porque es la fecha que tenemos que seleccionar en el datetimepicker
                DataGridView[] dt1 = new DataGridView[dt.Rows.Count];//se crea un arreglo de tablas esto para crear una tabla por cada especialista la cual contendra todas las citas por especialista.
                for (int a = 0; a < dt.Rows.Count; a++)//se recorre todas las filas de la tabla
                {
                    labelarray[a] = new Label();//se inicializa los label del array de labels
                    dt1[a] = new DataGridView();//se inicializa las tablas del array de tablas
                    dt1[a].ColumnCount = 2;// se coloca cuantas columnas tendra la tablas
                    dt1[a].ReadOnly = true;//se quita la posibilidad de poder editar.
                    for (int i = 0; i < 2; i++)//se recorre las columnas definidas
                    {
                        dt1[a].Columns[i].Resizable = System.Windows.Forms.DataGridViewTriState.False;//las dos columnas no son autoajustables
                    }
                    dt1[a].Columns[0].Name = "Hora Cita";//se coloca el primer nombre de la columna
                    dt1[a].Columns[1].Name = "Paciente";//se coloca el segundo nombre de la columna
                    //deshabilitar la opcion de agregar fila
                    dt1[a].AllowUserToAddRows = false;
                    dt1[a].Columns[0].Width = 60;//se coloca el ancho de la primera columna
                    dt1[a].Columns[1].Width = 100;//se coloca el ancho de la segunda columna
                    dt1[a].Size = new System.Drawing.Size(210, 250);//se coloca el tamaño que tendra la tabla
                    labelarray[a].AutoSize = true;//se coloca que la tabla se ajuste al contenido
                    labelarray[a].Font = replacementFont;// se utiliza la variable para pode definir el tipo de letra, estilo de letra y en negrita.
                    //este proceso se realiza para poder definir el tamaño
                    //letras, ancho de cada label y cada tabla que se debe crear por array
                }

                for (int i = 0; i < dt.Rows.Count; i++)//se recorre la tabla
                {
                    for (int a = 0; a < labelarray.Length; a++)//se recorre el array de labels
                    {
                        if (dt.Rows[i][2].ToString().Equals(labelarray[a].Text))//se valida si se tiene algun nombre de especialista ya definido en algun array
                        {
                            posicion = a;//si se tiene definido algun especialista se guarda en que array esta
                            y = 1;//es una bandera para validar si ya se tiene, 1=si 0=no
                        }
                    }
                    if (y == 0)//si la bandera es 0=no
                    {
                        //si es no se procede a generar un label con el nombre del especialista y crear la posicion de la tabla
                        dt1[i].Location = new System.Drawing.Point(x, 30);//posicion de la tabla
                        labelarray[i].Location = new System.Drawing.Point(x + 105 - (labelarray[i].Width/2), 5);//posicion del label
                        x = x + 215;//se suma 215 de la posicion de la tabla y del array esto se utiliza para que no se muestre el label y la tabla en la misma posicion
                        labelarray[i].Text = dt.Rows[i][2].ToString();//se coloca el nombre del especialista en el label
                        labelarray[i].Show();//se muestra el array
                        panel1.Controls.Add(labelarray[i]);//se agrega al panel
                        dt1[i].Rows.Add(dttemporal.Rows[i].ItemArray);//se agrega la fila a la tabla
                    }
                    else
                    {
                        //si la bandera es 1=si
                        dt1[posicion].Rows.Add(dttemporal.Rows[i].ItemArray);//se agrega la fila en la tabla segun posicion del label.
                        y = 0;//se coloca el valor por defecto 0=no
                    }
                    if (dt1[i].Rows.Count != 0)//si la tabla tiene filas
                        panel1.Controls.Add(dt1[i]);//se agrega al panel si no tiene ninguna fila no se realiza nada
                }
            }
            else
            {
                MessageBox.Show("No se encontraron Citas en esta fecha", "Cuadro Informativo");//si la tabla no tiene ningun registro se muestra el siguiente mensaje
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//evento al cambiar fecha 
        {
            panel1.Controls.Clear();//se limpia el panel para poder refrescar.
            crearvista();//se llena el panel.
        }
    }
}
