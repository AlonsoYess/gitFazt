using System.Data;
using CapaDatos;
using System;

namespace CapaNegocio
{
    public class ClienteDetalleNegocio
    {
        ClienteDetalleDatos _ClienteDetalleDatos = new ClienteDetalleDatos();
        public DataTable ClienteDetalleConsultarCAB(DateTime fechaInicial, DateTime fechaFinal, string codigoCliente, string codigoEmpresa)
        {
            return _ClienteDetalleDatos.ClienteDetalleConsultarCAB(fechaInicial, fechaFinal, codigoCliente,codigoEmpresa);
        }
    }
}
