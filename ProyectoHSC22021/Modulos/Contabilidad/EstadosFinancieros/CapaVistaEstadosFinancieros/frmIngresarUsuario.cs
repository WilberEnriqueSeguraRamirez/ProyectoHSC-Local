using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorEstadosFinancieros;

namespace CapaVistaEstadosFinancieros
{
    public partial class frmIngresarUsuario : Form
    {
        Controlador cn = new Controlador();
        public frmIngresarUsuario()
        {
            InitializeComponent();
            actualizardatagriew("registroActividad");
        }

        public void actualizardatagriew(string tabla)
        {
            DataTable dt = cn.llenarTabla(tabla);
            BDActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BDActividades.DataSource = dt;

        }
        private void frmIngresarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string id = IDActividad.Text;
            string nombre = Actividad.Text;
            string credito = Credito.Text;
            string debito = Debito.Text;
            string fecha = Fecha.Text;




            bool resultado = cn.ingresoActividad(id, nombre, credito, debito, fecha);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
                actualizardatagriew("registroActividad");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            IDActividad.Text = "";
            Actividad.Text = "";
            Credito.Text = "";
            Debito.Text = "";
            Fecha.Text = "";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //aca pido los datos
            string id = IDActividad.Text;
            string nombre = Actividad.Text;
            string credito = Credito.Text;
            string debito = Debito.Text;
            string fecha = Fecha.Text;


            bool resultado = cn.modificarActividad (id, nombre, credito, debito, fecha);

            if (resultado)
            {
                MessageBox.Show("Actualización correcta");
                actualizardatagriew("registroActividad");
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }

            IDActividad.Text = "";
            Actividad.Text = "";
            Credito.Text = "";
            Debito.Text = "";
            Fecha.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
