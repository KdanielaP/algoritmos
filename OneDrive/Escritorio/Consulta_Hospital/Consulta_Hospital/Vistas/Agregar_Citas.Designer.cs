namespace Consulta_Hospital.Vistas
{
    partial class Agregar_Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.APReloj = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.LHora = new System.Windows.Forms.Label();
            this.TBHora = new System.Windows.Forms.TextBox();
            this.TBDpi = new System.Windows.Forms.TextBox();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.CBEspecialidad = new System.Windows.Forms.ComboBox();
            this.LEspecialidad = new System.Windows.Forms.Label();
            this.LEspecialista = new System.Windows.Forms.Label();
            this.CBEspecialista = new System.Windows.Forms.ComboBox();
            this.TBSintomas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "02",
            "03",
            "04",
            "05"});
            this.comboBox1.Location = new System.Drawing.Point(458, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBox2.Location = new System.Drawing.Point(514, 38);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 25);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // APReloj
            // 
            this.APReloj.BackColor = System.Drawing.Color.Transparent;
            this.APReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APReloj.Location = new System.Drawing.Point(560, 41);
            this.APReloj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.APReloj.Name = "APReloj";
            this.APReloj.Size = new System.Drawing.Size(34, 19);
            this.APReloj.TabIndex = 5;
            this.APReloj.Text = "AM";
            // 
            // TBFecha
            // 
            this.TBFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFecha.Location = new System.Drawing.Point(296, 113);
            this.TBFecha.Margin = new System.Windows.Forms.Padding(2);
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(123, 20);
            this.TBFecha.TabIndex = 6;
            this.TBFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.Transparent;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(223, 115);
            this.LFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(72, 13);
            this.LFecha.TabIndex = 7;
            this.LFecha.Text = "Fecha Cita:";
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.BackColor = System.Drawing.Color.Transparent;
            this.LHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHora.Location = new System.Drawing.Point(224, 141);
            this.LHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(64, 13);
            this.LHora.TabIndex = 8;
            this.LHora.Text = "Hora Cita:";
            // 
            // TBHora
            // 
            this.TBHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBHora.Location = new System.Drawing.Point(296, 138);
            this.TBHora.Margin = new System.Windows.Forms.Padding(2);
            this.TBHora.Name = "TBHora";
            this.TBHora.ReadOnly = true;
            this.TBHora.Size = new System.Drawing.Size(74, 20);
            this.TBHora.TabIndex = 9;
            this.TBHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDpi
            // 
            this.TBDpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDpi.Location = new System.Drawing.Point(253, 187);
            this.TBDpi.Margin = new System.Windows.Forms.Padding(2);
            this.TBDpi.MaxLength = 13;
            this.TBDpi.Name = "TBDpi";
            this.TBDpi.Size = new System.Drawing.Size(109, 20);
            this.TBDpi.TabIndex = 10;
            this.TBDpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDpi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDpi_KeyPress);
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.Color.Transparent;
            this.Lbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.Location = new System.Drawing.Point(222, 162);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(202, 18);
            this.Lbuscar.TabIndex = 11;
            this.Lbuscar.Text = "Buscar Paciente por DPI";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Consulta_Hospital.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(369, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNombre.Location = new System.Drawing.Point(230, 214);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(186, 20);
            this.TBNombre.TabIndex = 13;
            // 
            // CBEspecialidad
            // 
            this.CBEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEspecialidad.FormattingEnabled = true;
            this.CBEspecialidad.Items.AddRange(new object[] {
            "",
            "Neurocirugía",
            "Cardiología",
            "Dermatología",
            "Endocrinología",
            "Gastroenterología",
            "Medicina Interna",
            "Nefrología",
            "Neumología",
            "Obstetricia y Ginecología",
            "Oftalmología",
            "Oncología",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Radiología",
            "Reumatología",
            "Traumatología y Ortopedia",
            "Urología"});
            this.CBEspecialidad.Location = new System.Drawing.Point(334, 236);
            this.CBEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.CBEspecialidad.Name = "CBEspecialidad";
            this.CBEspecialidad.Size = new System.Drawing.Size(86, 21);
            this.CBEspecialidad.TabIndex = 14;
            this.CBEspecialidad.SelectedIndexChanged += new System.EventHandler(this.CBEspecialidad_SelectedIndexChanged);
            // 
            // LEspecialidad
            // 
            this.LEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.LEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialidad.Location = new System.Drawing.Point(222, 236);
            this.LEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEspecialidad.Name = "LEspecialidad";
            this.LEspecialidad.Size = new System.Drawing.Size(107, 19);
            this.LEspecialidad.TabIndex = 15;
            this.LEspecialidad.Text = "Especialidad:";
            this.LEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LEspecialista
            // 
            this.LEspecialista.BackColor = System.Drawing.Color.Transparent;
            this.LEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialista.Location = new System.Drawing.Point(223, 264);
            this.LEspecialista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEspecialista.Name = "LEspecialista";
            this.LEspecialista.Size = new System.Drawing.Size(106, 19);
            this.LEspecialista.TabIndex = 16;
            this.LEspecialista.Text = "Especialista:";
            this.LEspecialista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBEspecialista
            // 
            this.CBEspecialista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEspecialista.FormattingEnabled = true;
            this.CBEspecialista.Location = new System.Drawing.Point(334, 263);
            this.CBEspecialista.Margin = new System.Windows.Forms.Padding(2);
            this.CBEspecialista.Name = "CBEspecialista";
            this.CBEspecialista.Size = new System.Drawing.Size(86, 21);
            this.CBEspecialista.TabIndex = 17;
            // 
            // TBSintomas
            // 
            this.TBSintomas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSintomas.Location = new System.Drawing.Point(228, 308);
            this.TBSintomas.Margin = new System.Windows.Forms.Padding(2);
            this.TBSintomas.Multiline = true;
            this.TBSintomas.Name = "TBSintomas";
            this.TBSintomas.Size = new System.Drawing.Size(186, 58);
            this.TBSintomas.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sintomas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(268, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Agregar Cita";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(95, 35);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(200, 20);
            this.Calendario.TabIndex = 21;
            this.Calendario.ValueChanged += new System.EventHandler(this.Calendario_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha:";
            // 
            // Agregar_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consulta_Hospital.Properties.Resources._9131696;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSintomas);
            this.Controls.Add(this.CBEspecialista);
            this.Controls.Add(this.LEspecialista);
            this.Controls.Add(this.LEspecialidad);
            this.Controls.Add(this.CBEspecialidad);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbuscar);
            this.Controls.Add(this.TBDpi);
            this.Controls.Add(this.TBHora);
            this.Controls.Add(this.LHora);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.APReloj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Agregar_Citas";
            this.Text = "Agregar_Citas";
            this.Load += new System.EventHandler(this.Agregar_Citas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label APReloj;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.TextBox TBHora;
        private System.Windows.Forms.TextBox TBDpi;
        private System.Windows.Forms.Label Lbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.ComboBox CBEspecialidad;
        private System.Windows.Forms.Label LEspecialidad;
        private System.Windows.Forms.Label LEspecialista;
        private System.Windows.Forms.ComboBox CBEspecialista;
        private System.Windows.Forms.TextBox TBSintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker Calendario;
        private System.Windows.Forms.Label label3;
    }
}