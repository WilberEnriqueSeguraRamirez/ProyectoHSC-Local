using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloEstadosFinancieros;
using System.Data;
using System.Data.Odbc;
using System.Collections;

namespace CapaControladorEstadosFinancieros
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

      
        public DataTable llenarTabla(string tabla)//Método Genérico para llenar datagrids
        {
            OdbcDataAdapter dt = sn.llenarTabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public bool ingresoActividad (string idActividad, string nombreActividad, string credito, string debito, string fecha)
        {
            return sn.ingresoActividad( idActividad, nombreActividad, credito, debito, fecha );

        }
        public bool modificarActividad (string idActividad, string nombreActividad, string credito, string debito, string fecha)
        {
            return sn.modificarActividad(idActividad, nombreActividad, credito, debito, fecha);

        }
    }
}

