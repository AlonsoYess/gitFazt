using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VentasGCNegocio
    {
        VentasGCDatos _VentasGCDatos = new VentasGCDatos();
        public DataTable VentasGCListarCDatos(DateTime  fecha1, DateTime fecha2, String Canal)
        {
            return _VentasGCDatos.VentasGCListarCDatos(fecha1, fecha2, Canal);
        }
    } 


}
