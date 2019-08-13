using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SAPVentasGCPuntoNegocio
    {
        SAPVentasGCPuntoDatos _SAPVentasGCPuntoDatos = new SAPVentasGCPuntoDatos();
        public DataTable VentasGCPuntoSAPConsultar(DateTime  fecha1, DateTime fecha2, String Canal)
        {
            return _SAPVentasGCPuntoDatos.VentasGCPuntoSAPConsultar(fecha1, fecha2, Canal);
        }
    } 
}
