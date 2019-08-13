using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VentasGCMarcaNegocio
    {
        VentasGCMarcaDatos _VentasGCMarcaDatos = new VentasGCMarcaDatos();
        public DataTable VentasGCMarcaListarCDatos(DateTime fecha1, DateTime fecha2,string Empresa)
        {
            return _VentasGCMarcaDatos.VentasGCMarcaListarCDatos(fecha1, fecha2,Empresa);
        }
    } 


}
