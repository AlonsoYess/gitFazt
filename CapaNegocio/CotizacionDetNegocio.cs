using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CotizacionDetNegocio
    {
        CotizacionDetDatos _CotizacionDetDatos = new CotizacionDetDatos();
        public DataTable CotizacionDetConsultar(string vcot, string vemp, string vdoc)
        {
            return _CotizacionDetDatos.CotizacionDetConsultar( vcot, vemp,  vdoc );
        }
    }
}
