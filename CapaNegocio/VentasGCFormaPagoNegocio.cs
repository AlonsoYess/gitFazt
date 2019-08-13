using System.Data;
using CapaDatos;
using System;

namespace CapaNegocio
{
    public class VentasGCFormaPagoNegocio
    {
        VentasGCFormaPagoDatos _VentasGCFormaPagoDatos = new VentasGCFormaPagoDatos();
        public DataTable VentasGCFormaPagoListarCDatos(DateTime fecha1, DateTime fecha2,string Empresa)
        {
            return _VentasGCFormaPagoDatos.VentasGCFormaPagoListarCDatos(fecha1, fecha2,Empresa);
        }
    } 


}
