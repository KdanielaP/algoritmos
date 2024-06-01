namespace Consulta_Hospital.Vistas
{
    partial class modificar_paciente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Sangre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DPI,
            this.Nombre_Paciente,
            this.ApellidoP,
            this.Edad,
            this.Sexo,
            this.Telefono,
            this.Direccion,
            this.Correo,
            this.Tipo_Sangre});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // DPI
            // 
            this.DPI.DataPropertyName = "DPI";
            this.DPI.HeaderText = "DPI";
            this.DPI.MaxInputLength = 13;
            this.DPI.MinimumWidth = 6;
            this.DPI.Name = "DPI";
            this.DPI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DPI.Width = 75;
            // 
            // Nombre_Paciente
            // 
            this.Nombre_Paciente.DataPropertyName = "Nombre_Paciente";
            this.Nombre_Paciente.HeaderText = "Nombre Paciente";
            this.Nombre_Paciente.MinimumWidth = 6;
            this.Nombre_Paciente.Name = "Nombre_Paciente";
            this.Nombre_Paciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre_Paciente.Width = 125;
            // 
            // ApellidoP
            // 
            this.ApellidoP.DataPropertyName = "Apellido_Paciente";
            this.ApellidoP.HeaderText = "Apellido Paciente";
            this.ApellidoP.MinimumWidth = 6;
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Width = 125;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MaxInputLength = 3;
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 50;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sexo.Width = 50;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 75;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direccion.Width = 125;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Tipo_Sangre
            // 
            this.Tipo_Sangre.DataPropertyName = "Tipo_Sangre";
            this.Tipo_Sangre.HeaderText = "Tipo Sangre";
            this.Tipo_Sangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.Tipo_Sangre.MinimumWidth = 6;
            this.Tipo_Sangre.Name = "Tipo_Sangre";
            this.Tipo_Sangre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo_Sangre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tipo_Sangre.Width = 75;
            // 
            // modificar_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modificar_paciente";
            this.Text = "modificar_paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo_Sangre;
    }
}