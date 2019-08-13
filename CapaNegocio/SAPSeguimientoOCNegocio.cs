using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPSeguimientoOCNegocio
    {
        SAPSeguimientoOCDatos _SAPSeguimientoOCDatos = new SAPSeguimientoOCDatos();
        public DataSet SeguimientoOCDS(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Entrada, string Factura)
        {
            return _SAPSeguimientoOCDatos.SAPSeguimientoOCDS(FechaInicio,FechaFin,CodProveedor,NomProveedor,Solicitud,Orden,Entrada,Factura);
        }
        public DataTable SeguimientoOCDT(DateTime FechaInicio, DateTime FechaFin, string CodProveedor, string NomProveedor, string Solicitud, string Orden, string Entrada, string Factura)
        {
            return _SAPSeguimientoOCDatos.SAPSeguimientoOCDT(FechaInicio, FechaFin, CodProveedor, NomProveedor, Solicitud, Orden, Entrada, Factura);
        }

    }
}
