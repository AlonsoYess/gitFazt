using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class LogisticaStockMinNegocio
    {
        LogisticaStockMinDatos _LogisticaStockMinDatos = new LogisticaStockMinDatos();
        public DataTable LogisticaStockMinListarCDatos(string fecha1, string fecha2, String Canal)
        {
            return _LogisticaStockMinDatos.LogisticaStockMinListarCDatos(fecha1, fecha2, Canal);
        }
        public DataSet LogisticaStockMinListarDS(string fecha1, string fecha2, String Canal)
        {
            return _LogisticaStockMinDatos.LogisticaStockMinListarDS(fecha1, fecha2, Canal);
        }
    } 


}
