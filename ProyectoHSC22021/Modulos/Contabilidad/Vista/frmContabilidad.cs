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

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientosContaJNLD.mantenimientoCuentas frm7701 = new MantenimientosContaJNLD.mantenimientoCuentas();
            frm7701.MdiParent = this;
            frm7701.funActualizarUsuario(txtUsuario.Text);
            frm7701.Show();
        }

        private void tipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientosContaJNLD.mantenimientoTipoCuenta frm7702 = new MantenimientosContaJNLD.mantenimientoTipoCuenta();
            frm7702.MdiParent = this;
            frm7702.funActualizarUsuario(txtUsuario.Text);
            frm7702.Show();
        }

        private void tipoOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientosContaJNLD.mantenimientoTipoOperacion frm7703 = new MantenimientosContaJNLD.mantenimientoTipoOperacion();
            frm7703.MdiParent = this;
            frm7703.funActualizarUsuario(txtUsuario.Text);
            frm7703.Show();
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientosContaJNLD.mantenimientoImpuestos frm7704 = new MantenimientosContaJNLD.mantenimientoImpuestos();
            frm7704.MdiParent = this;
            frm7704.funActualizarUsuario(txtUsuario.Text);
            frm7704.Show();
        }

        private void pólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void polizasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda/poliza/ayudas.chm", "ayuda/poliza/Manual-de-usuario.html");
        }

        private void ingresoActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaEstadosFinancieros.frmIngresarUsuario formulario = new CapaVistaEstadosFinancieros.frmIngresarUsuario();
            formulario.Show();
            formulario.MdiParent = this;
        }

        private void estadosFinancierosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
    
           
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda/estadosFinancieros/AyudaEstadosFinancieros.chm", "ayuda/estadosFinancieros/Manual-de-Usuario-Estados-Financieros.html");
        }

        private void manualTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda/estadosFinancieros/AyudaEstadosFinancieros1.chm", "ayuda/estadosFinancieros/Manuel-Tecnico-Estados-Financieros.html");
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVistaPresupuestos.frmPresupuesto formulario = new CapaVistaPresupuestos.frmPresupuesto();
            formulario.Show();
            formulario.MdiParent = this;
            formulario.funActualizarUsuario(txtUsuario.Text);
        }
    }
}
