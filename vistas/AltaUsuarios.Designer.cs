using PacientesC.bbdd;

namespace PacientesC.vistas
{
    partial class AltaUsuarios
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formulario = new System.Windows.Forms.GroupBox();
            this.botonRegistro = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 35);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesC.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(505, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.botonRegistro);
            this.formulario.Controls.Add(this.campoNombre);
            this.formulario.Controls.Add(this.campoUsuario);
            this.formulario.Controls.Add(this.campoPass);
            this.formulario.Controls.Add(this.label3);
            this.formulario.Controls.Add(this.label2);
            this.formulario.Controls.Add(this.label1);
            this.formulario.Location = new System.Drawing.Point(105, 41);
            this.formulario.Name = "formulario";
            this.formulario.Size = new System.Drawing.Size(371, 300);
            this.formulario.TabIndex = 5;
            this.formulario.TabStop = false;
            this.formulario.Text = "Registro Usuarios";
            // 
            // botonRegistro
            // 
            this.botonRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.BorderSize = 2;
            this.botonRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistro.Location = new System.Drawing.Point(139, 250);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(89, 31);
            this.botonRegistro.TabIndex = 4;
            this.botonRegistro.Text = "Registrar";
            this.botonRegistro.UseVisualStyleBackColor = true;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(217, 58);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(148, 22);
            this.campoNombre.TabIndex = 1;
            this.campoNombre.Tag = "NOMBRE";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(217, 130);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(148, 22);
            this.campoUsuario.TabIndex = 2;
            this.campoUsuario.Tag = "USUARIOS";
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(217, 197);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(148, 22);
            this.campoPass.TabIndex = 3;
            this.campoPass.Tag = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // AltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(592, 353);
            this.Controls.Add(this.formulario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(610, 400);
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "AltaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox formulario;
        private System.Windows.Forms.Button botonRegistro;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public void Registrar()
        {
            string nombre = campoNombre.Text;
            string usuario = campoUsuario.Text;
            string pass = Utilidades.Encriptado.Encriptar(campoPass.Text);

            if (Utilidades.Validaciones.ValidaFormulario(formulario))
            {
                if(Conexion.CompruebaUsuario(usuario))
                {

                }
                else
                {
                    MessageBox.Show("El usuario ya existe.");
                }
            }
        }
    }
}