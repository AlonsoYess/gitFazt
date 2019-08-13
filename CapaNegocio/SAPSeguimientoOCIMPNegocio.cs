using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPSeguimientoOCIMPNegocio
    {
        SAPSeguimientoOCIMPDatos _SAPSeguimientoOCIMPDatos = new SAPSeguimientoOCIMPDatos();
        public DataSet SeguimientoOCIMPDS(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Reserva, string Entrada, string Precio, string Transferencia)
        {
            return _SAPSeguimientoOCIMPDatos.SAPSeguimientoOCIMPDS(FechaInicio,FechaFin,CodProveedor,NomProveedor,Solicitud,Orden,Reserva,Entrada,Precio,Transferencia);
        }
        public DataTable SeguimientoOCIMPDT(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Reserva, string Entrada, string Precio, string Transferencia)
        {
            return _SAPSeguimientoOCIMPDatos.SAPSeguimientoOCIMPDT(FechaInicio, FechaFin, CodProveedor, NomProveedor, Solicitud, Orden, Reserva, Entrada, Precio, Transferencia);
        }

    }
}
