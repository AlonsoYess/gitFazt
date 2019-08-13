using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPStockxProductoNegocio
    {
        SAPStockxProductoDatos _SAPStockxProductoDatos = new SAPStockxProductoDatos();
        public DataTable VentasSTOCKSAPConsultar( String CodigoStock )
        {
            return _SAPStockxProductoDatos.VentasSTOCKSAPConsultar( CodigoStock );
        }
    }
}
