using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVistaReporte;

namespace Vista
{
    public partial class frmContabilidad : Form
    {
        public frmContabilidad()
        {
            InitializeComponent();
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           CapaVistaReporte.ReporteadorAdmin formulario = new CapaVistaReporte.ReporteadorAdmin(); 
            formulario.Show();
        }

        private void consultasInteligentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapaVista.ConsultasInteligentes formulario = new CapaVista.ConsultasInteligentes();
            formulario.Show();
        }

        private void menúConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista.menuconsultas formulario = new CapaVista.menuconsultas();
            formulario.Show();
        }

        private void frmContabilidad_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close(); }
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaSeguridadHSC.frmMIDSeguridad formulario = new CapaVistaSeguridadHSC.frmMIDSeguridad();
            formulario.Show();
        }

        private void ayudaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoTipoPólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmTipoPoliza formulario = new CapaVistaPolizas.frmTipoPoliza();
            formulario.Show();
            formulario.MdiParent = this;

        }

        private void ingresoEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmPolizaEncabezado formulario = new CapaVistaPolizas.frmPolizaEncabezado();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresoTipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmTipoCuenta formulario = new CapaVistaPolizas.frmTipoCuenta();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresoTipoOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmTipoOperacion formulario = new CapaVistaPolizas.frmTipoOperacion();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void detalleDePólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmPolizaDetalle formulario = new CapaVistaPolizas.frmPolizaDetalle();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void ingresoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmCuenta formulario = new CapaVistaPolizas.frmCuenta();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void modificarPólizaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmModificarPolizaDetalle formulario = new CapaVistaPolizas.frmModificarPolizaDetalle();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void modificarEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmModificarPolizaEncabezado formulario = new CapaVistaPolizas.frmModificarPolizaEncabezado();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void modificarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPolizas.frmModificarCuenta formulario = new CapaVistaPolizas.frmModificarCuenta();
            formulario.Show();
            formulario.MdiParent = this;
        }
    }
}
