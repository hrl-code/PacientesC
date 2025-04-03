namespace PacientesC.vistas
{
    partial class Principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonPacientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonTabla = new System.Windows.Forms.Button();
            this.botonUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesC.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(875, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 34);
            this.panel1.TabIndex = 2;
            // 
            // botonPacientes
            // 
            this.botonPacientes.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonPacientes.FlatAppearance.BorderSize = 3;
            this.botonPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPacientes.Location = new System.Drawing.Point(3, 14);
            this.botonPacientes.Name = "botonPacientes";
            this.botonPacientes.Size = new System.Drawing.Size(150, 126);
            this.botonPacientes.TabIndex = 0;
            this.botonPacientes.Text = "Alta pacientes";
            this.botonPacientes.UseVisualStyleBackColor = true;
            this.botonPacientes.Click += new System.EventHandler(this.botonPacientes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonTabla);
            this.panel2.Controls.Add(this.botonUsuario);
            this.panel2.Controls.Add(this.botonPacientes);
            this.panel2.Location = new System.Drawing.Point(172, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 159);
            this.panel2.TabIndex = 3;
            // 
            // botonTabla
            // 
            this.botonTabla.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonTabla.FlatAppearance.BorderSize = 3;
            this.botonTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabla.Location = new System.Drawing.Point(489, 16);
            this.botonTabla.Name = "botonTabla";
            this.botonTabla.Size = new System.Drawing.Size(150, 126);
            this.botonTabla.TabIndex = 2;
            this.botonTabla.Text = "Listado pacientes";
            this.botonTabla.UseVisualStyleBackColor = true;
            this.botonTabla.Click += new System.EventHandler(this.botonTabla_Click);
            // 
            // botonUsuario
            // 
            this.botonUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonUsuario.FlatAppearance.BorderSize = 3;
            this.botonUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonUsuario.Location = new System.Drawing.Point(246, 16);
            this.botonUsuario.Name = "botonUsuario";
            this.botonUsuario.Size = new System.Drawing.Size(150, 126);
            this.botonUsuario.TabIndex = 1;
            this.botonUsuario.Text = "Alta usuario";
            this.botonUsuario.UseVisualStyleBackColor = true;
            this.botonUsuario.Click += new System.EventHandler(this.botonUsuario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 525);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 525);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonPacientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonTabla;
        private System.Windows.Forms.Button botonUsuario;
    }
}