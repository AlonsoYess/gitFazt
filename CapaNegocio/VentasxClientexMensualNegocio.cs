using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class VentasxClientexMensualNegocio
    {
        VentasxClientexMensualDatos _VentasxClientexMensualDatos = new VentasxClientexMensualDatos();
        public DataSet VentasGeneralesDetalleConsultarDS(DateTime fechaInicio, DateTime fechaFin, string vendedor, string empresa, string cliente)
        {
            return _VentasxClientexMensualDatos.VentasGeneralesDetalleConsultarDS(fechaInicio, fechaFin, vendedor, empresa, cliente);
        }
        public DataTable VentasGeneralesDetalleConsultarDT(DateTime fechaInicio, DateTime fechaFin, string vendedor, string empresa, string cliente)
        {
            return _VentasxClientexMensualDatos.VentasGeneralesDetalleConsultarDT(fechaInicio, fechaFin, vendedor, empresa, cliente);
        }

    }
}
