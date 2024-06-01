namespace Consulta_Hospital.Vistas
{
    partial class Agregar_Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LContraeña = new System.Windows.Forms.Label();
            this.TBcontraseña = new System.Windows.Forms.TextBox();
            this.LEspecialista = new System.Windows.Forms.Label();
            this.CBEspecialista = new System.Windows.Forms.ComboBox();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.LRol = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Consulta_Hospital.Properties.Resources.fadf;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(441, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 423);
            this.panel1.TabIndex = 0;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(28, 90);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(71, 20);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Usuario";
            this.LUsuario.Click += new System.EventHandler(this.LUsuario_Click);
            // 
            // TBUsuario
            // 
            this.TBUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsuario.Location = new System.Drawing.Point(186, 90);
            this.TBUsuario.MaxLength = 10;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(142, 20);
            this.TBUsuario.TabIndex = 2;
            this.TBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LContraeña
            // 
            this.LContraeña.AutoSize = true;
            this.LContraeña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraeña.Location = new System.Drawing.Point(28, 137);
            this.LContraeña.Name = "LContraeña";
            this.LContraeña.Size = new System.Drawing.Size(102, 20);
            this.LContraeña.TabIndex = 3;
            this.LContraeña.Text = "Contraseña";
            // 
            // TBcontraseña
            // 
            this.TBcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBcontraseña.Location = new System.Drawing.Point(186, 137);
            this.TBcontraseña.Name = "TBcontraseña";
            this.TBcontraseña.Size = new System.Drawing.Size(142, 20);
            this.TBcontraseña.TabIndex = 4;
            this.TBcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LEspecialista
            // 
            this.LEspecialista.AutoSize = true;
            this.LEspecialista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEspecialista.Location = new System.Drawing.Point(28, 192);
            this.LEspecialista.Name = "LEspecialista";
            this.LEspecialista.Size = new System.Drawing.Size(106, 20);
            this.LEspecialista.TabIndex = 5;
            this.LEspecialista.Text = "Especialista";
            // 
            // CBEspecialista
            // 
            this.CBEspecialista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEspecialista.FormattingEnabled = true;
            this.CBEspecialista.Location = new System.Drawing.Point(186, 191);
            this.CBEspecialista.Name = "CBEspecialista";
            this.CBEspecialista.Size = new System.Drawing.Size(238, 21);
            this.CBEspecialista.TabIndex = 6;
            // 
            // CBRol
            // 
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Doctor",
            "Enfermera"});
            this.CBRol.Location = new System.Drawing.Point(186, 246);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(131, 21);
            this.CBRol.TabIndex = 8;
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(28, 247);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(36, 20);
            this.LRol.TabIndex = 7;
            this.LRol.Text = "Rol";
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = global::Consulta_Hospital.Properties.Resources.agregar_usuario__1_;
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Agregar.Location = new System.Drawing.Point(196, 299);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 44);
            this.Agregar.TabIndex = 9;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Agregar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.LRol);
            this.Controls.Add(this.CBEspecialista);
            this.Controls.Add(this.LEspecialista);
            this.Controls.Add(this.TBcontraseña);
            this.Controls.Add(this.LContraeña);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Usuario";
            this.Text = "Agregar_Usuario";
            this.Load += new System.EventHandler(this.Agregar_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LContraeña;
        private System.Windows.Forms.TextBox TBcontraseña;
        private System.Windows.Forms.Label LEspecialista;
        private System.Windows.Forms.ComboBox CBEspecialista;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Button Agregar;
    }
}