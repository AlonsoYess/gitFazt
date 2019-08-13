using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductoStockNegocio
    {
        ProductoStockDatos _ProductoStockDatos = new ProductoStockDatos();
        public DataTable ProductoStockListar(string parametro)
        {
            return _ProductoStockDatos.ProductoStockListar(parametro);
        }
    }


}
