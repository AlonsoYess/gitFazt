using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SAPVentasGCNegocio
    {
        SAPVentasGCDatos _SAPVentasGCDatos = new SAPVentasGCDatos();
        public DataTable VentasGCSAPConsultar(DateTime  fecha1, DateTime fecha2, String Canal)
        {
            return _SAPVentasGCDatos.VentasGCSAPConsultar(fecha1, fecha2, Canal);
        }
    } 


}
