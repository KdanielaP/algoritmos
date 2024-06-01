namespace Consulta_Hospital.Vistas
{
    partial class Cambiar_Contraseña
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
            this.tablaMUser = new System.Windows.Forms.DataGridView();
            this.Codigo_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaMUser
            // 
            this.tablaMUser.AllowUserToAddRows = false;
            this.tablaMUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Usuario,
            this.Usuario,
            this.Contraseña,
            this.Especialista,
            this.Especialidad,
            this.Rol});
            this.tablaMUser.Location = new System.Drawing.Point(2, 1);
            this.tablaMUser.Margin = new System.Windows.Forms.Padding(2);
            this.tablaMUser.Name = "tablaMUser";
            this.tablaMUser.RowHeadersWidth = 51;
            this.tablaMUser.RowTemplate.Height = 24;
            this.tablaMUser.Size = new System.Drawing.Size(653, 422);
            this.tablaMUser.TabIndex = 1;
            this.tablaMUser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMUser_CellEndEdit);
            // 
            // Codigo_Usuario
            // 
            this.Codigo_Usuario.DataPropertyName = "Codigo_Usuario";
            this.Codigo_Usuario.HeaderText = "Codigo Usuario";
            this.Codigo_Usuario.MinimumWidth = 6;
            this.Codigo_Usuario.Name = "Codigo_Usuario";
            this.Codigo_Usuario.ReadOnly = true;
            this.Codigo_Usuario.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MaxInputLength = 10;
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MaxInputLength = 13;
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Especialista
            // 
            this.Especialista.DataPropertyName = "Nombre_Completo";
            this.Especialista.HeaderText = "Especialista";
            this.Especialista.MinimumWidth = 6;
            this.Especialista.Name = "Especialista";
            this.Especialista.ReadOnly = true;
            this.Especialista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Especialista.Width = 190;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Estado_Usuario";
            this.Especialidad.HeaderText = "Estado Usuario";
            this.Especialidad.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Width = 75;
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 80;
            // 
            // Cambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.tablaMUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cambiar_Contraseña";
            this.Text = "Cambiar_Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaMUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialista;
        private System.Windows.Forms.DataGridViewComboBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}