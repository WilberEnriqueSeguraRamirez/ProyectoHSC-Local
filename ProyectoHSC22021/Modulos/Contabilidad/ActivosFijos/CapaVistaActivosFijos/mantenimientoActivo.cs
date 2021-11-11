using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaActivosFijos
{
    public partial class mantenimientoActivo : Form
    {
        private string usuario = "";
        public mantenimientoActivo()
        {
            InitializeComponent();

           

            TextBox[] alias = navegador1.funAsignandoTexts(this);
            //definicion de textboxs, tabla y BD
            navegador1.funAsignarAliasVista(alias, "activosfijos", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //definicion del campo de estado / para dar de bajars
            navegador1.campoEstado = "estado";

            //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
            navegador1.idAplicacion = "7404";//en la nueva se usara el nombre

            //-- Estos atributos no cambian
            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda

            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes
            //-- fin de atributos no cambiantes

            //enviar el data grid view para la navegaciÃ³n
            navegador1.pideGrid(this.dgvactivo);
            //llena el data grid
            navegador1.llenaTabla();
            //pide la referencia a la form para poder cerrarla
            navegador1.pedirRef(this);

            navegador1.funLlenarComboControl(cmbtipoact, "tipoactivo", "idTipoactivo", "nombreTipoactivo", "estado");
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbtipoact, txttipoact);
        }

        private void txtTipoCuenta_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbtipoact, txttipoact);
        }

        private void dgvImpuesto_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvactivo);
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }
        public void funActualizarUsuario(string user)
        {
            usuario = user;
            navegador1.usuario = user;
            navegador1.aplicacion = "Mantenimiento Activo";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "7";
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
        }
    

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
