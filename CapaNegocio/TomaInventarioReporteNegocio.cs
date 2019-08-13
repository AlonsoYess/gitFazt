using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class TomaInventarioReporteNegocio
    {
        TomaInventarioReporteDatos _TomaInventarioReporteDatos = new TomaInventarioReporteDatos();
        public DataSet TomaInventarioReporteDS(string NroInventario)
        {
            return _TomaInventarioReporteDatos.TomaInventarioReporteDS(NroInventario);
        }
        public DataTable TomaInventarioReporteDT(string NroInventario)
        {
            return _TomaInventarioReporteDatos.TomaInventarioReporteDT(NroInventario);
        }

    }
}
