namespace Consulta_Hospital.Vistas
{
    partial class Diagnostico
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
            this.LtipoDiag = new System.Windows.Forms.Label();
            this.CBTipoDiag = new System.Windows.Forms.ComboBox();
            this.LEspecialista = new System.Windows.Forms.Label();
            this.TBEspecialista = new System.Windows.Forms.TextBox();
            this.TBDPI = new System.Windows.Forms.TextBox();
            this.LDPI = new System.Windows.Forms.Label();
            this.TBFecha = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.TBDiagnostico = new System.Windows.Forms.TextBox();
            this.LDiagnostico = new System.Windows.Forms.Label();
            this.TBReceta = new System.Windows.Forms.TextBox();
            this.LReceta = new System.Windows.Forms.Label();
            this.TBNPaciente = new System.Windows.Forms.TextBox();
            this.LNPaciente = new System.Windows.Forms.Label();
            this.LServicios = new System.Windows.Forms.Label();
            this.TServicios = new System.Windows.Forms.DataGridView();
            this.CBServicio = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BAgregarServicio = new System.Windows.Forms.Button();
            this.BTRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPago = new System.Windows.Forms.TextBox();
            this.Codigo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // LtipoDiag
            // 
            this.LtipoDiag.AutoSize = true;
            this.LtipoDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LtipoDiag.Location = new System.Drawing.Point(5, 21);
            this.LtipoDiag.Name = "LtipoDiag";
            this.LtipoDiag.Size = new System.Drawing.Size(143, 20);
            this.LtipoDiag.TabIndex = 0;
            this.LtipoDiag.Text = "Tipo Diagnostico";
            // 
            // CBTipoDiag
            // 
            this.CBTipoDiag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDiag.FormattingEnabled = true;
            this.CBTipoDiag.Items.AddRange(new object[] {
            "",
            "Inicial",
            "Seguimiento",
            "Finalización"});
            this.CBTipoDiag.Location = new System.Drawing.Point(154, 21);
            this.CBTipoDiag.Name = "CBTipoDiag";
            this.CBTipoDiag.Size = new System.Drawing.Size(121, 21);
            this.CBTipoDiag.TabIndex = 1;
            this.CBTipoDiag.SelectedIndexChanged += new System.EventHandler(this.CBTipoDiag_SelectedIndexChanged);
            // 
            // LEspecialista
            // 
            this.LEspecialista.AutoSize = true;
            this.LEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialista.Location = new System.Drawing.Point(5, 59);
            this.LEspecialista.Name = "LEspecialista";
            this.LEspecialista.Size = new System.Drawing.Size(106, 20);
            this.LEspecialista.TabIndex = 2;
            this.LEspecialista.Text = "Especialista";
            // 
            // TBEspecialista
            // 
            this.TBEspecialista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBEspecialista.Location = new System.Drawing.Point(117, 59);
            this.TBEspecialista.Name = "TBEspecialista";
            this.TBEspecialista.ReadOnly = true;
            this.TBEspecialista.Size = new System.Drawing.Size(527, 20);
            this.TBEspecialista.TabIndex = 3;
            this.TBEspecialista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDPI
            // 
            this.TBDPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDPI.Location = new System.Drawing.Point(50, 99);
            this.TBDPI.MaxLength = 13;
            this.TBDPI.Name = "TBDPI";
            this.TBDPI.Size = new System.Drawing.Size(98, 20);
            this.TBDPI.TabIndex = 5;
            this.TBDPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LDPI
            // 
            this.LDPI.AutoSize = true;
            this.LDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDPI.Location = new System.Drawing.Point(5, 99);
            this.LDPI.Name = "LDPI";
            this.LDPI.Size = new System.Drawing.Size(39, 20);
            this.LDPI.TabIndex = 4;
            this.LDPI.Text = "DPI";
            // 
            // TBFecha
            // 
            this.TBFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFecha.Location = new System.Drawing.Point(514, 20);
            this.TBFecha.MaxLength = 13;
            this.TBFecha.Name = "TBFecha";
            this.TBFecha.ReadOnly = true;
            this.TBFecha.Size = new System.Drawing.Size(121, 20);
            this.TBFecha.TabIndex = 7;
            this.TBFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(349, 20);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(159, 20);
            this.LFecha.TabIndex = 6;
            this.LFecha.Text = "Fecha Diagnostico";
            // 
            // TBDiagnostico
            // 
            this.TBDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDiagnostico.Location = new System.Drawing.Point(1, 156);
            this.TBDiagnostico.Multiline = true;
            this.TBDiagnostico.Name = "TBDiagnostico";
            this.TBDiagnostico.Size = new System.Drawing.Size(316, 97);
            this.TBDiagnostico.TabIndex = 9;
            this.TBDiagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LDiagnostico
            // 
            this.LDiagnostico.AutoSize = true;
            this.LDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDiagnostico.Location = new System.Drawing.Point(95, 133);
            this.LDiagnostico.Name = "LDiagnostico";
            this.LDiagnostico.Size = new System.Drawing.Size(104, 20);
            this.LDiagnostico.TabIndex = 8;
            this.LDiagnostico.Text = "Diagnostico";
            // 
            // TBReceta
            // 
            this.TBReceta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBReceta.Location = new System.Drawing.Point(323, 156);
            this.TBReceta.Multiline = true;
            this.TBReceta.Name = "TBReceta";
            this.TBReceta.Size = new System.Drawing.Size(332, 97);
            this.TBReceta.TabIndex = 11;
            this.TBReceta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LReceta
            // 
            this.LReceta.AutoSize = true;
            this.LReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReceta.Location = new System.Drawing.Point(452, 133);
            this.LReceta.Name = "LReceta";
            this.LReceta.Size = new System.Drawing.Size(67, 20);
            this.LReceta.TabIndex = 10;
            this.LReceta.Text = "Receta";
            // 
            // TBNPaciente
            // 
            this.TBNPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNPaciente.Location = new System.Drawing.Point(380, 99);
            this.TBNPaciente.Name = "TBNPaciente";
            this.TBNPaciente.ReadOnly = true;
            this.TBNPaciente.Size = new System.Drawing.Size(264, 20);
            this.TBNPaciente.TabIndex = 13;
            this.TBNPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LNPaciente
            // 
            this.LNPaciente.AutoSize = true;
            this.LNPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNPaciente.Location = new System.Drawing.Point(228, 99);
            this.LNPaciente.Name = "LNPaciente";
            this.LNPaciente.Size = new System.Drawing.Size(146, 20);
            this.LNPaciente.TabIndex = 12;
            this.LNPaciente.Text = "Nombre Paciente";
            // 
            // LServicios
            // 
            this.LServicios.AutoSize = true;
            this.LServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LServicios.Location = new System.Drawing.Point(95, 261);
            this.LServicios.Name = "LServicios";
            this.LServicios.Size = new System.Drawing.Size(81, 20);
            this.LServicios.TabIndex = 16;
            this.LServicios.Text = "Servicios";
            // 
            // TServicios
            // 
            this.TServicios.AllowUserToAddRows = false;
            this.TServicios.AllowUserToDeleteRows = false;
            this.TServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Servicio,
            this.Nombre_Servicio,
            this.Precio_Minimo,
            this.Precio_Maximo,
            this.Precio_Actual,
            this.Eliminar});
            this.TServicios.Location = new System.Drawing.Point(284, 259);
            this.TServicios.Name = "TServicios";
            this.TServicios.ReadOnly = true;
            this.TServicios.Size = new System.Drawing.Size(371, 161);
            this.TServicios.TabIndex = 17;
            this.TServicios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TServicios_CellMouseClick);
            // 
            // CBServicio
            // 
            this.CBServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBServicio.FormattingEnabled = true;
            this.CBServicio.Location = new System.Drawing.Point(6, 291);
            this.CBServicio.Name = "CBServicio";
            this.CBServicio.Size = new System.Drawing.Size(252, 21);
            this.CBServicio.TabIndex = 19;
            this.CBServicio.SelectedIndexChanged += new System.EventHandler(this.CBServicio_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Consulta_Hospital.Properties.Resources.icons8_escoba_48;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(152, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAgregarServicio
            // 
            this.BAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarServicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BAgregarServicio.Image = global::Consulta_Hospital.Properties.Resources.login24;
            this.BAgregarServicio.Location = new System.Drawing.Point(4, 328);
            this.BAgregarServicio.Name = "BAgregarServicio";
            this.BAgregarServicio.Size = new System.Drawing.Size(140, 31);
            this.BAgregarServicio.TabIndex = 20;
            this.BAgregarServicio.Text = "Agregar Servicio";
            this.BAgregarServicio.UseVisualStyleBackColor = true;
            this.BAgregarServicio.Click += new System.EventHandler(this.BAgregarServicio_Click);
            // 
            // BTRegistrar
            // 
            this.BTRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrar.Image = global::Consulta_Hospital.Properties.Resources.Login23;
            this.BTRegistrar.Location = new System.Drawing.Point(95, 381);
            this.BTRegistrar.Name = "BTRegistrar";
            this.BTRegistrar.Size = new System.Drawing.Size(100, 31);
            this.BTRegistrar.TabIndex = 15;
            this.BTRegistrar.Text = "Registrar";
            this.BTRegistrar.UseVisualStyleBackColor = true;
            this.BTRegistrar.Click += new System.EventHandler(this.BTRegistrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Consulta_Hospital.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(184, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Q.";
            // 
            // TBPago
            // 
            this.TBPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPago.Enabled = false;
            this.TBPago.Location = new System.Drawing.Point(208, 332);
            this.TBPago.Name = "TBPago";
            this.TBPago.Size = new System.Drawing.Size(52, 20);
            this.TBPago.TabIndex = 23;
            this.TBPago.Text = "0";
            this.TBPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Codigo_Servicio
            // 
            this.Codigo_Servicio.DataPropertyName = "Codigo_Servicio";
            this.Codigo_Servicio.HeaderText = "Codigo";
            this.Codigo_Servicio.Name = "Codigo_Servicio";
            this.Codigo_Servicio.ReadOnly = true;
            this.Codigo_Servicio.Width = 50;
            // 
            // Nombre_Servicio
            // 
            this.Nombre_Servicio.DataPropertyName = "Nombre_Servicio";
            this.Nombre_Servicio.HeaderText = "Nombre Servicio";
            this.Nombre_Servicio.Name = "Nombre_Servicio";
            this.Nombre_Servicio.ReadOnly = true;
            this.Nombre_Servicio.Width = 175;
            // 
            // Precio_Minimo
            // 
            this.Precio_Minimo.DataPropertyName = "Precio_Minimo";
            this.Precio_Minimo.HeaderText = "Precio Minimo";
            this.Precio_Minimo.Name = "Precio_Minimo";
            this.Precio_Minimo.ReadOnly = true;
            this.Precio_Minimo.Visible = false;
            // 
            // Precio_Maximo
            // 
            this.Precio_Maximo.DataPropertyName = "Precio_Maximo";
            this.Precio_Maximo.HeaderText = "Precio Maximo";
            this.Precio_Maximo.Name = "Precio_Maximo";
            this.Precio_Maximo.ReadOnly = true;
            this.Precio_Maximo.Visible = false;
            // 
            // Precio_Actual
            // 
            this.Precio_Actual.DataPropertyName = "Precio_Actual";
            this.Precio_Actual.HeaderText = "Precio";
            this.Precio_Actual.Name = "Precio_Actual";
            this.Precio_Actual.ReadOnly = true;
            this.Precio_Actual.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 50;
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.TBPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BAgregarServicio);
            this.Controls.Add(this.CBServicio);
            this.Controls.Add(this.TServicios);
            this.Controls.Add(this.LServicios);
            this.Controls.Add(this.BTRegistrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBNPaciente);
            this.Controls.Add(this.LNPaciente);
            this.Controls.Add(this.TBReceta);
            this.Controls.Add(this.LReceta);
            this.Controls.Add(this.TBDiagnostico);
            this.Controls.Add(this.LDiagnostico);
            this.Controls.Add(this.TBFecha);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.TBDPI);
            this.Controls.Add(this.LDPI);
            this.Controls.Add(this.TBEspecialista);
            this.Controls.Add(this.LEspecialista);
            this.Controls.Add(this.CBTipoDiag);
            this.Controls.Add(this.LtipoDiag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            ((System.ComponentModel.ISupportInitialize)(this.TServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LtipoDiag;
        private System.Windows.Forms.ComboBox CBTipoDiag;
        private System.Windows.Forms.Label LEspecialista;
        private System.Windows.Forms.TextBox TBEspecialista;
        private System.Windows.Forms.TextBox TBDPI;
        private System.Windows.Forms.Label LDPI;
        private System.Windows.Forms.TextBox TBFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TBDiagnostico;
        private System.Windows.Forms.Label LDiagnostico;
        private System.Windows.Forms.TextBox TBReceta;
        private System.Windows.Forms.Label LReceta;
        private System.Windows.Forms.TextBox TBNPaciente;
        private System.Windows.Forms.Label LNPaciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTRegistrar;
        private System.Windows.Forms.Label LServicios;
        private System.Windows.Forms.DataGridView TServicios;
        private System.Windows.Forms.ComboBox CBServicio;
        private System.Windows.Forms.Button BAgregarServicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Actual;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}