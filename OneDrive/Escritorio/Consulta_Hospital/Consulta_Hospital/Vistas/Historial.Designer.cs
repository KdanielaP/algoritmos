namespace Consulta_Hospital.Vistas
{
    partial class Historial
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TBNPaciente = new System.Windows.Forms.TextBox();
            this.LNPaciente = new System.Windows.Forms.Label();
            this.TBDPI = new System.Windows.Forms.TextBox();
            this.LDPI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Consulta_Hospital.Properties.Resources.icons8_escoba_48;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(159, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Consulta_Hospital.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(191, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBNPaciente
            // 
            this.TBNPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNPaciente.Location = new System.Drawing.Point(387, 17);
            this.TBNPaciente.Name = "TBNPaciente";
            this.TBNPaciente.ReadOnly = true;
            this.TBNPaciente.Size = new System.Drawing.Size(264, 20);
            this.TBNPaciente.TabIndex = 25;
            this.TBNPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBNPaciente.TextChanged += new System.EventHandler(this.TBNPaciente_TextChanged);
            // 
            // LNPaciente
            // 
            this.LNPaciente.AutoSize = true;
            this.LNPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNPaciente.Location = new System.Drawing.Point(235, 17);
            this.LNPaciente.Name = "LNPaciente";
            this.LNPaciente.Size = new System.Drawing.Size(146, 20);
            this.LNPaciente.TabIndex = 24;
            this.LNPaciente.Text = "Nombre Paciente";
            // 
            // TBDPI
            // 
            this.TBDPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDPI.Location = new System.Drawing.Point(57, 17);
            this.TBDPI.MaxLength = 13;
            this.TBDPI.Name = "TBDPI";
            this.TBDPI.Size = new System.Drawing.Size(98, 20);
            this.TBDPI.TabIndex = 23;
            this.TBDPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LDPI
            // 
            this.LDPI.AutoSize = true;
            this.LDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDPI.Location = new System.Drawing.Point(12, 17);
            this.LDPI.Name = "LDPI";
            this.LDPI.Size = new System.Drawing.Size(39, 20);
            this.LDPI.TabIndex = 22;
            this.LDPI.Text = "DPI";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(-2, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 364);
            this.panel1.TabIndex = 28;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBNPaciente);
            this.Controls.Add(this.LNPaciente);
            this.Controls.Add(this.TBDPI);
            this.Controls.Add(this.LDPI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBNPaciente;
        private System.Windows.Forms.Label LNPaciente;
        private System.Windows.Forms.TextBox TBDPI;
        private System.Windows.Forms.Label LDPI;
        private System.Windows.Forms.Panel panel1;
    }
}