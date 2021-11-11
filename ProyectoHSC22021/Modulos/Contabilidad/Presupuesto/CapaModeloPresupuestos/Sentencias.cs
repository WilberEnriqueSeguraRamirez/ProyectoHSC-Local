using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModeloPresupuestos
{
    class Sentencias
    {
        public OdbcDataAdapter llenarTabla(string tabla)//Método Genérico para llenar tabla
        {
            Conexion cn = new Conexion();//Variable para abrir conexión
            string sql = "select * from ";//Aquí ponemos la tabla 
            OdbcConnection conn = cn.conexion();//Abrimos conexión
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);//Cerramos conexión

            return dataTable;
        }
    }
}
