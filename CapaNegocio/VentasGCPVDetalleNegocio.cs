using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VentasGCPVDetalleNegocio
    {
        VentasGCPVDetalleDatos _VentasGCPVDetalleDatos = new VentasGCPVDetalleDatos();
        public DataTable VentasGCPVDetalleListarCDatos(string punto, string vendedor, DateTime fecha1, DateTime fecha2)
        {
            return _VentasGCPVDetalleDatos.VentasGCPVDetalleListarCDatos(punto, vendedor, fecha1, fecha2);
        }
    } 


}
