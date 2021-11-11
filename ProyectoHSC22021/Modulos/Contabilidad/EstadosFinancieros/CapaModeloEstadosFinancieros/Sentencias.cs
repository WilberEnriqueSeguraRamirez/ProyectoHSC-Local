using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace CapaModeloEstadosFinancieros
{
    public class Sentencias
    {

        Conexion cn = new Conexion();
        //Daniel Enrique Navas Hernandez 0901-18-15032
         public OdbcDataAdapter llenarTabla(string tabla)//Método Genérico para llenar tabla
         {
            Conexion cn = new Conexion();//Variable para abrir conexión
            string sql = "select * from " + tabla + ";";//Aquí ponemos la tabla 
            OdbcConnection conn = cn.conexion();//Abrimos conexión
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);//Cerramos conexión

            return dataTable;
         }
        public bool ingresoActividad (string idActividad, string nombreActividad, string credito, string debito, string fecha)  //ingresoTipoPoliza
        {
            int i = 0;
            try
            {
                string cadena = "insert into registroActividad values ('" + idActividad + "','" + nombreActividad + "','" + credito + "','" + debito + "','" + fecha + "');";
                OdbcCommand ingreso = new OdbcCommand(cadena, cn.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public bool modificarActividad (string idActividad, string nombreActividad, string credito, string debito, string fecha)
        {
            int i = 0;
            try
            {
                string cadena = "update registroActividad SET nombreActividad = '" + nombreActividad + "' ,credito= '" + credito + "' ,debito = '" + debito + "' ,fecha = '" + fecha + "'  where idActividad='" + idActividad + "';";
                OdbcCommand ingreso = new OdbcCommand(cadena, cn.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar privilegio" + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
