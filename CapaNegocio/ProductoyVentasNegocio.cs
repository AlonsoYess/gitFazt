using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ProductoyVentasNegocio
    {
        ProductoyVentasDatos _ProductoyVentasDatos = new ProductoyVentasDatos();
        public DataTable ProductoyVentasListar(string codigo , string ruc,string empresa)
        {
            return _ProductoyVentasDatos.ProductoyVentaListar(codigo, ruc,empresa);
        }
    } 


}
