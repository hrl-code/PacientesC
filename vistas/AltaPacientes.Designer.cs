using PacientesC.bbdd;
using PacientesC.Utilidades;
using System.Windows.Forms;

namespace PacientesC.vistas
{
    partial class AltaPacientes
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
            this.formulario = new System.Windows.Forms.GroupBox();
            this.botonRegistro = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 35);
            this.panel1.TabIndex = 2;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.botonRegistro);
            this.formulario.Controls.Add(this.campoNombre);
            this.formulario.Controls.Add(this.campoApellidos);
            this.formulario.Controls.Add(this.campoDireccion);
            this.formulario.Controls.Add(this.comboCiudad);
            this.formulario.Controls.Add(this.label4);
            this.formulario.Controls.Add(this.label3);
            this.formulario.Controls.Add(this.label2);
            this.formulario.Controls.Add(this.label1);
            this.formulario.Location = new System.Drawing.Point(127, 41);
            this.formulario.Name = "formulario";
            this.formulario.Size = new System.Drawing.Size(324, 300);
            this.formulario.TabIndex = 3;
            this.formulario.TabStop = false;
            this.formulario.Text = "Alta pacientes";
            // 
            // botonRegistro
            // 
            this.botonRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.BorderSize = 2;
            this.botonRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistro.Location = new System.Drawing.Point(111, 249);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(89, 31);
            this.botonRegistro.TabIndex = 5;
            this.botonRegistro.Text = "Registrar";
            this.botonRegistro.UseVisualStyleBackColor = true;
            this.botonRegistro.Click += new System.EventHandler(this.botonRegistro_Click);
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(170, 58);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(148, 22);
            this.campoNombre.TabIndex = 1;
            this.campoNombre.Tag = "NOMBRE";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(170, 98);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(148, 22);
            this.campoApellidos.TabIndex = 2;
            this.campoApellidos.Tag = "APELLIDOS";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(170, 142);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(148, 22);
            this.campoDireccion.TabIndex = 3;
            this.campoDireccion.Tag = "DIRECCION";
            // 
            // comboCiudad
            // 
            this.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Location = new System.Drawing.Point(170, 190);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(148, 24);
            this.comboCiudad.TabIndex = 4;
            this.comboCiudad.Tag = "CIUDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesC.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(505, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AltaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 353);
            this.Controls.Add(this.formulario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(610, 400);
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "AltaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA DE PACIENTES";
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox formulario;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonRegistro;

        public void Registrar()

        {
            string nombre = Encriptado.Encriptar(campoNombre.Text);
            string apellidos = Encriptado.Encriptar(campoApellidos.Text);
            string direccion = Encriptado.Encriptar(campoDireccion.Text);
            string ciudad = Encriptado.Encriptar(comboCiudad.Text);

            if (Validaciones.ValidaFormulario(formulario))
            {
                Modelo.Paciente paciente = new Modelo.Paciente(nombre, apellidos, direccion, ciudad);
                if (!Conexion.RegistrarPaciente(paciente))
                {
                    MessageBox.Show("Error al registrar el paciente");
                    return;
                }
                else
                {
                    MessageBox.Show("Paciente registrado correctamente");
                }
                MessageBox.Show("Registro exitoso");
                Validaciones.LimpiarFormulario(formulario);
            }
        }
    }
}