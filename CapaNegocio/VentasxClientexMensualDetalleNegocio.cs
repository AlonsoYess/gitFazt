using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class VentasxClientexMensualDetalleNegocio
    {
        VentasxClientexMensualDetalleDatos _VentasxClientexMensualDetalleDatos = new VentasxClientexMensualDetalleDatos();
        public DataSet VxClienteDetalleDS(DateTime fechaInicio, DateTime fechaFin, string vendedor, string cliente, string empresa)
        {
            return _VentasxClientexMensualDetalleDatos.VxClienteDetalleDS(fechaInicio, fechaFin, vendedor, cliente, empresa);
        }
        public DataTable VxClienteDetalleDT(DateTime fechaInicio, DateTime fechaFin, string vendedor, string cliente, string empresa)
        {
            return _VentasxClientexMensualDetalleDatos.VxClienteDetalleDT(fechaInicio, fechaFin, vendedor, cliente, empresa);
        }

    }
}
