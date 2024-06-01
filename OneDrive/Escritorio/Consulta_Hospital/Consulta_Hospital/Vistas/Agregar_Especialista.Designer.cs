namespace Consulta_Hospital.Vistas
{
    partial class Agregar_Especialista
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
            this.LNombreCompletoEspecialista = new System.Windows.Forms.Label();
            this.TBNC = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LTefono = new System.Windows.Forms.Label();
            this.TBCE = new System.Windows.Forms.TextBox();
            this.LCE = new System.Windows.Forms.Label();
            this.CBCE = new System.Windows.Forms.ComboBox();
            this.LES = new System.Windows.Forms.Label();
            this.CBEs = new System.Windows.Forms.ComboBox();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.LimpiarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombreCompletoEspecialista
            // 
            this.LNombreCompletoEspecialista.AutoSize = true;
            this.LNombreCompletoEspecialista.BackColor = System.Drawing.Color.Transparent;
            this.LNombreCompletoEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCompletoEspecialista.ForeColor = System.Drawing.Color.Black;
            this.LNombreCompletoEspecialista.Location = new System.Drawing.Point(12, 34);
            this.LNombreCompletoEspecialista.Name = "LNombreCompletoEspecialista";
            this.LNombreCompletoEspecialista.Size = new System.Drawing.Size(192, 25);
            this.LNombreCompletoEspecialista.TabIndex = 0;
            this.LNombreCompletoEspecialista.Text = "Nombre Completo:";
            // 
            // TBNC
            // 
            this.TBNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNC.Location = new System.Drawing.Point(225, 34);
            this.TBNC.Name = "TBNC";
            this.TBNC.Size = new System.Drawing.Size(456, 22);
            this.TBNC.TabIndex = 1;
            // 
            // TBTelefono
            // 
            this.TBTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTelefono.Location = new System.Drawing.Point(225, 101);
            this.TBTelefono.MaxLength = 8;
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(193, 22);
            this.TBTelefono.TabIndex = 3;
            this.TBTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTelefono_KeyPress);
            // 
            // LTefono
            // 
            this.LTefono.AutoSize = true;
            this.LTefono.BackColor = System.Drawing.Color.Transparent;
            this.LTefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTefono.ForeColor = System.Drawing.Color.Black;
            this.LTefono.Location = new System.Drawing.Point(12, 101);
            this.LTefono.Name = "LTefono";
            this.LTefono.Size = new System.Drawing.Size(104, 25);
            this.LTefono.TabIndex = 2;
            this.LTefono.Text = "Telefono:";
            // 
            // TBCE
            // 
            this.TBCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCE.Location = new System.Drawing.Point(225, 166);
            this.TBCE.Name = "TBCE";
            this.TBCE.Size = new System.Drawing.Size(192, 22);
            this.TBCE.TabIndex = 5;
            this.TBCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LCE
            // 
            this.LCE.AutoSize = true;
            this.LCE.BackColor = System.Drawing.Color.Transparent;
            this.LCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCE.ForeColor = System.Drawing.Color.Black;
            this.LCE.Location = new System.Drawing.Point(12, 166);
            this.LCE.Name = "LCE";
            this.LCE.Size = new System.Drawing.Size(198, 25);
            this.LCE.TabIndex = 4;
            this.LCE.Text = "Correo Electronico:";
            // 
            // CBCE
            // 
            this.CBCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCE.FormattingEnabled = true;
            this.CBCE.Items.AddRange(new object[] {
            "",
            "gmail.com",
            "outlook.com",
            "yahoo.com",
            "hotmail.com",
            "aol.com",
            "zoho.com",
            "gmx.com",
            "mail.com"});
            this.CBCE.Location = new System.Drawing.Point(423, 165);
            this.CBCE.Name = "CBCE";
            this.CBCE.Size = new System.Drawing.Size(182, 24);
            this.CBCE.TabIndex = 6;
            // 
            // LES
            // 
            this.LES.AutoSize = true;
            this.LES.BackColor = System.Drawing.Color.Transparent;
            this.LES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LES.ForeColor = System.Drawing.Color.Black;
            this.LES.Location = new System.Drawing.Point(12, 234);
            this.LES.Name = "LES";
            this.LES.Size = new System.Drawing.Size(142, 25);
            this.LES.TabIndex = 7;
            this.LES.Text = "Especialidad:";
            // 
            // CBEs
            // 
            this.CBEs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEs.FormattingEnabled = true;
            this.CBEs.Items.AddRange(new object[] {
            "",
            "Secretaria",
            "Enfermera",
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
            this.CBEs.Location = new System.Drawing.Point(225, 234);
            this.CBEs.Name = "CBEs";
            this.CBEs.Size = new System.Drawing.Size(293, 24);
            this.CBEs.TabIndex = 8;
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BTAgregar.BackgroundImage = global::Consulta_Hospital.Properties.Resources.agregar__2_;
            this.BTAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTAgregar.Location = new System.Drawing.Point(301, 406);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(75, 65);
            this.BTAgregar.TabIndex = 9;
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // LimpiarPaciente
            // 
            this.LimpiarPaciente.AutoSize = true;
            this.LimpiarPaciente.BackgroundImage = global::Consulta_Hospital.Properties.Resources.limpieza_de_datos;
            this.LimpiarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LimpiarPaciente.Location = new System.Drawing.Point(530, 406);
            this.LimpiarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarPaciente.Name = "LimpiarPaciente";
            this.LimpiarPaciente.Size = new System.Drawing.Size(64, 70);
            this.LimpiarPaciente.TabIndex = 20;
            this.LimpiarPaciente.UseVisualStyleBackColor = true;
            this.LimpiarPaciente.Click += new System.EventHandler(this.LimpiarPaciente_Click);
            // 
            // Agregar_Especialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consulta_Hospital.Properties.Resources._106185234_equipo_médico_sobre_un_fondo_rosa_pastel__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 522);
            this.Controls.Add(this.LimpiarPaciente);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.CBEs);
            this.Controls.Add(this.LES);
            this.Controls.Add(this.CBCE);
            this.Controls.Add(this.TBCE);
            this.Controls.Add(this.LCE);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.LTefono);
            this.Controls.Add(this.TBNC);
            this.Controls.Add(this.LNombreCompletoEspecialista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Especialista";
            this.Text = "Agregar_Especialista";
            this.Load += new System.EventHandler(this.Agregar_Especialista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombreCompletoEspecialista;
        private System.Windows.Forms.TextBox TBNC;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label LTefono;
        private System.Windows.Forms.TextBox TBCE;
        private System.Windows.Forms.Label LCE;
        private System.Windows.Forms.ComboBox CBCE;
        private System.Windows.Forms.Label LES;
        private System.Windows.Forms.ComboBox CBEs;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button LimpiarPaciente;
    }
}