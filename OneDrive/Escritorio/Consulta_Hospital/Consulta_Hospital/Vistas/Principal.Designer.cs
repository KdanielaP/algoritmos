namespace Consulta_Hospital
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.subusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.porPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPreciosDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginUsuario2 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.userlogeado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(177, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 424);
            this.panel1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackgroundImage = global::Consulta_Hospital.Properties.Resources._360_F_360513715_BEbDvSencBZV1KrQtOf8k2RX91T70pq2;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subusuarios,
            this.citasToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.especialistasToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(175, 427);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // subusuarios
            // 
            this.subusuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porPacienteToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.subusuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.subusuarios.Image = global::Consulta_Hospital.Properties.Resources.intimidad__1_;
            this.subusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.subusuarios.Name = "subusuarios";
            this.subusuarios.Size = new System.Drawing.Size(170, 36);
            this.subusuarios.Text = "Usuarios";
            // 
            // porPacienteToolStripMenuItem
            // 
            this.porPacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.agregar_usuario2;
            this.porPacienteToolStripMenuItem.Name = "porPacienteToolStripMenuItem";
            this.porPacienteToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.porPacienteToolStripMenuItem.Text = "Agregar Usuario";
            this.porPacienteToolStripMenuItem.Click += new System.EventHandler(this.porPacienteToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.editar_perfil;
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCitas});
            this.citasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citasToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.chequeo;
            this.citasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // ingresarCitas
            // 
            this.ingresarCitas.Image = global::Consulta_Hospital.Properties.Resources.agregar__1_;
            this.ingresarCitas.Name = "ingresarCitas";
            this.ingresarCitas.Size = new System.Drawing.Size(176, 26);
            this.ingresarCitas.Text = "Ingresar Cita";
            this.ingresarCitas.Click += new System.EventHandler(this.ingresarCitaToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrearPacienteToolStripMenuItem,
            this.modificarPacienteToolStripMenuItem});
            this.pacienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.paciente;
            this.pacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // agrearPacienteToolStripMenuItem
            // 
            this.agrearPacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.cita_medica;
            this.agrearPacienteToolStripMenuItem.Name = "agrearPacienteToolStripMenuItem";
            this.agrearPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agrearPacienteToolStripMenuItem.Text = "Agrear Paciente";
            this.agrearPacienteToolStripMenuItem.Click += new System.EventHandler(this.agrearPacienteToolStripMenuItem_Click);
            // 
            // modificarPacienteToolStripMenuItem
            // 
            this.modificarPacienteToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.editar;
            this.modificarPacienteToolStripMenuItem.Name = "modificarPacienteToolStripMenuItem";
            this.modificarPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarPacienteToolStripMenuItem.Text = "Modificar Paciente";
            this.modificarPacienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPacienteToolStripMenuItem_Click);
            // 
            // especialistasToolStripMenuItem
            // 
            this.especialistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEspecialistaToolStripMenuItem,
            this.modificarEspecialistaToolStripMenuItem});
            this.especialistasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.especialistasToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.medico;
            this.especialistasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.especialistasToolStripMenuItem.Name = "especialistasToolStripMenuItem";
            this.especialistasToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.especialistasToolStripMenuItem.Text = "Especialistas";
            this.especialistasToolStripMenuItem.Click += new System.EventHandler(this.especialistasToolStripMenuItem_Click);
            // 
            // agregarEspecialistaToolStripMenuItem
            // 
            this.agregarEspecialistaToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.doctor;
            this.agregarEspecialistaToolStripMenuItem.Name = "agregarEspecialistaToolStripMenuItem";
            this.agregarEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.agregarEspecialistaToolStripMenuItem.Text = "Agregar Especialista";
            this.agregarEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.agregarEspecialistaToolStripMenuItem_Click);
            // 
            // modificarEspecialistaToolStripMenuItem
            // 
            this.modificarEspecialistaToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.editar;
            this.modificarEspecialistaToolStripMenuItem.Name = "modificarEspecialistaToolStripMenuItem";
            this.modificarEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.modificarEspecialistaToolStripMenuItem.Text = "Modificar Especialista";
            this.modificarEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.modificarEspecialistaToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarServiciosToolStripMenuItem,
            this.modificarPreciosDeServiciosToolStripMenuItem,
            this.diagnosticoToolStripMenuItem});
            this.serviciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.serviciosToolStripMenuItem.Image = global::Consulta_Hospital.Properties.Resources.edificio_del_hospital;
            this.serviciosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // agregarServiciosToolStripMenuItem
            // 
            this.agregarServiciosToolStripMenuItem.Name = "agregarServiciosToolStripMenuItem";
            this.agregarServiciosToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.agregarServiciosToolStripMenuItem.Text = "Agregar Servicios";
            this.agregarServiciosToolStripMenuItem.Click += new System.EventHandler(this.agregarServiciosToolStripMenuItem_Click);
            // 
            // modificarPreciosDeServiciosToolStripMenuItem
            // 
            this.modificarPreciosDeServiciosToolStripMenuItem.Name = "modificarPreciosDeServiciosToolStripMenuItem";
            this.modificarPreciosDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.modificarPreciosDeServiciosToolStripMenuItem.Text = "Modificar Precios de Servicios";
            this.modificarPreciosDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.modificarPreciosDeServiciosToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::Consulta_Hospital.Properties.Resources.carpeta;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 36);
            this.toolStripMenuItem1.Text = "Historial Medico";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem2.Text = "Por Paciente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // LoginUsuario2
            // 
            this.LoginUsuario2.AutoSize = true;
            this.LoginUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsuario2.Location = new System.Drawing.Point(53, 302);
            this.LoginUsuario2.Name = "LoginUsuario2";
            this.LoginUsuario2.Size = new System.Drawing.Size(0, 20);
            this.LoginUsuario2.TabIndex = 2;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(1, 354);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(65, 16);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.Text = "Usuario:";
            // 
            // userlogeado
            // 
            this.userlogeado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userlogeado.Enabled = false;
            this.userlogeado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlogeado.Location = new System.Drawing.Point(72, 351);
            this.userlogeado.Name = "userlogeado";
            this.userlogeado.Size = new System.Drawing.Size(100, 20);
            this.userlogeado.TabIndex = 4;
            this.userlogeado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Consulta_Hospital.Properties.Resources.login24;
            this.button1.Location = new System.Drawing.Point(27, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userlogeado);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.LoginUsuario2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Medico";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem agrearPacienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem modificarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPreciosDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem especialistasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subusuarios;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem ingresarCitas;
        private System.Windows.Forms.Label LoginUsuario2;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox userlogeado;
        private System.Windows.Forms.Button button1;
    }
}

