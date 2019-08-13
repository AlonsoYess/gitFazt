using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPQuiebreStockNegocio
    {
        SAPQuiebreStockDatos _SAPQuiebreStockDato = new SAPQuiebreStockDatos();
        public DataSet QuiebreStockPDS()
        {
            return _SAPQuiebreStockDato.QuiebreStockDS();
        }
        public DataTable QuiebreStockPDT()
        {
            return _SAPQuiebreStockDato.QuiebreStockDT();
        }

    }
}
