using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacientesC.vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void botonPacientes_Click(object sender, EventArgs e)
        {
            AltaPacientes altaPacientes = new AltaPacientes();
            altaPacientes.Show();
        }

        private void botonUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuarios altaUsuarios = new AltaUsuarios();
            altaUsuarios.Show();

        }

        private void botonTabla_Click(object sender, EventArgs e)
        {
            TablaPacientes tablaPacientes = new TablaPacientes();
            tablaPacientes.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
