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
    public partial class TablaPacientes : Form
    {
        public TablaPacientes()
        {
            InitializeComponent();
            bbdd.Conexion.GetPacientes(dataGridView1);
        }
    }
}
