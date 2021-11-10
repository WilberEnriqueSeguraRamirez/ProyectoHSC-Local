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
    public partial class frmTipoPoliza : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();

        public frmTipoPoliza()
        {
            InitializeComponent();
            actualizardatagriew("tipopoliza");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgPoliza.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPoliza.DataSource = dt;

        }

        private void btntTpoPoliza_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idTipoCuenta = txtIdPoliza.Text;
            string descripcion = txtDescripcion.Text;


            bool resultado = nuevoCn.ingresoTipoPoliza(idTipoCuenta, descripcion);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("tipopoliza");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtIdPoliza.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
