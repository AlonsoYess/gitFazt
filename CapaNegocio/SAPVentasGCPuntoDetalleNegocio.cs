using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SAPVentasGCPuntoDetalleNegocio
    {
        SAPVentasGCPuntoDetalleDatos _SAPVentasGCPuntoDetalleDatos = new SAPVentasGCPuntoDetalleDatos();
        public DataTable VentasGCPuntoDetalleSAPConsultar(DateTime  fecha1, DateTime fecha2, String Canal, String Vendedor)
        {
            return _SAPVentasGCPuntoDetalleDatos.VentasGCPuntoDetalleSAPConsultar(fecha1, fecha2, Canal, Vendedor);
        }
    } 
}
