using System.Data;
using CapaDatos;
using System;

namespace CapaNegocio
{
    public class VentasGCPVNegocio
    {
        VentasGCPVDatos _VentasGCPVDatos = new VentasGCPVDatos();
        public DataTable VentasGCPVListarCDatos(String punto, DateTime fecha1, DateTime fecha2)
        {
            return _VentasGCPVDatos.VentasGCPVListarCDatos(punto, fecha1, fecha2);
        }
    } 

}
