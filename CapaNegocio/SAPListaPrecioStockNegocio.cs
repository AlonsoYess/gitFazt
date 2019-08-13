using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPListaPrecioStockNegocio
    {
        SAPListaPrecioStockDatos _SAPListaPrecioStockDatos = new SAPListaPrecioStockDatos();
        public DataTable SapListaPrecioDT()
        {
            return _SAPListaPrecioStockDatos.SapListaPrecioDT();
        }
        public DataTable SapListaPrecioDetalleDT(string Lista)
        {
            return _SAPListaPrecioStockDatos.SapListaPrecioDetalleDT( Lista);
        }

    }
}
