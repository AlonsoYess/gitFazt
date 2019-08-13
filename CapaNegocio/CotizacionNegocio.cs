using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CotizacionNegocio
    {
        CotizacionDatos _CotizacionDatos = new CotizacionDatos();
        public DataTable CotizacionConsultar(string dato)
        {
            return _CotizacionDatos.CotizacionConsultar(dato);
        }
    }
}
