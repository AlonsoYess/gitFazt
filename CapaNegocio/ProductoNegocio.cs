using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class ProductoNegocio
    {
        ProductoDatos _ProductoDatos = new ProductoDatos();
        public DataTable ProductoConsultar(string dato)
        {
            return _ProductoDatos.ProductoConsultar( dato);
        }
    }
}
