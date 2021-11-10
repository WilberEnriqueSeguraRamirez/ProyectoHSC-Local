using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPolizas
{
    public partial class frmCuenta : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmCuenta()
        {
            InitializeComponent();
            actualizardatagriew("cuenta");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCuenta.DataSource = dt;

        }
        private void btnIngresoCuenta_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idCuenta = txtIdCuenta.Text;
            string nombre = txtNombre.Text;
            string idTipoCuenta = txtIdTipoCuenta.Text;
            string cargo = txtCargo.Text;
            string abono = txtAbono.Text;
            string saldoAcumulado = txtSaldo.Text;
            string IdPadre = txtCuentaPadre.Text;

            bool resultado = nuevoCn.ingresoCuenta(idCuenta, nombre, idTipoCuenta, cargo, abono, saldoAcumulado, IdPadre);

            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("cuenta");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }

            txtIdCuenta.Text = "";
            txtNombre.Text = "";
            txtIdTipoCuenta.Text = "";
            txtCargo.Text = "";
            txtAbono.Text = "";
            txtSaldo.Text = "";
            txtCuentaPadre.Text = "";

        }
    }
}
