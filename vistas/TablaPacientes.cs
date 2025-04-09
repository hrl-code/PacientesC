using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacientesC.bbdd;

namespace PacientesC.vistas
{
    public partial class TablaPacientes : Form
    {
        public TablaPacientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = Conexion.GetPacientes();
        }
    }
}
