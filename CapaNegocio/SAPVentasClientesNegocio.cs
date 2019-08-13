using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPVentasClientesNegocio
    {
        SAPVentasClientesDatos _SAPVentaClientesDatos = new SAPVentasClientesDatos();
        public DataSet VentasGeneralesDetalladaSAPDS(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _SAPVentaClientesDatos.VentaClienteDS(fechaInicial, fechaFinal);
        }
        public DataTable VentasGeneralesDetalladaSAPDT(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _SAPVentaClientesDatos.VentaClienteDT(fechaInicial, fechaFinal);
        }


        public DataTable ClienteCartera(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _SAPVentaClientesDatos.ClienteCartera(fechaInicial, fechaFinal);
        }
    }
}
