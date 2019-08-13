using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SapStockXMarcaNegocio
    {
        SapStockXMarcaDatos _SapStockXMarcaDatos = new SapStockXMarcaDatos();
        public DataSet SAPListaPrecioStockDS(string Marca)
        {
            return _SapStockXMarcaDatos.VentasGeneralesDetalladaSAPDS(Marca);
        }
        public DataTable SAPListaPrecioStockDT(string Marca)
        {
            return _SapStockXMarcaDatos.VentasGeneralesDetalladaSAPDT(Marca);
        }

    }
}
