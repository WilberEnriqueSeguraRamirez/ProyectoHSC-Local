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
    public partial class frmTipoCuenta : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmTipoCuenta()
        {
            InitializeComponent();
            actualizardatagriew("tipocuenta");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgTipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTipo.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idCuenta = txtTipoCuenta.Text;
            string nombre = txtDescripcion.Text;


            bool resultado = nuevoCn.ingresotipoCuenta(idCuenta, nombre);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("tipocuenta");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtTipoCuenta.Text = "";
            txtDescripcion.Text = "";
        }

    }
}
