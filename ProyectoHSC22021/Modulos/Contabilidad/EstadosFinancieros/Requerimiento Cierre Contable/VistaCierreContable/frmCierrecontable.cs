using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaCierreContable
{
    public partial class frmCierrecontable : Form
    {
        public frmCierrecontable()
        {
            InitializeComponent();
        }

        private void cierreNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso formulario = new frmIngreso();
            formulario.Show();
        }
    }
}
