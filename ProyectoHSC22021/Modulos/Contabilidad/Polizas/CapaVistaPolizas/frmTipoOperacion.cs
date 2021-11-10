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
    public partial class frmTipoOperacion : Form
    {
        Controlador.Controlador nuevoCn = new Controlador.Controlador();
        public frmTipoOperacion()
        {
            InitializeComponent();
            actualizardatagriew("tipooperacion");
        }


        public void actualizardatagriew(string tabla)
        {
            DataTable dt = nuevoCn.llenarTabla(tabla);
            dvgOperacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgOperacion.DataSource = dt;

        }

        private void btnIngresarTipoOperacion_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string idTipoOperacion = txtTipoOperacion.Text;
            string nombre = txtNombre.Text;




            bool resultado = nuevoCn.ingresoTipoOperacion(idTipoOperacion, nombre);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("tipooperacion");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            txtTipoOperacion.Text = "";
            txtNombre.Text = "";

        }
    }
}
