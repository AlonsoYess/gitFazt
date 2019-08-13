using System;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class GuiaRemisionPendienteNegocio
    {
        GuiaRemisionPendienteDatos _GuiaRemisionPendienteDatos = new GuiaRemisionPendienteDatos();
        public DataTable GuiaRemisionPendienteListarDT(DateTime fecha1, DateTime fecha2, String Serie, string Estado, string empresa)
        {
            return _GuiaRemisionPendienteDatos.GuiaRemisionPendienteListarDT(fecha1, fecha2, Serie, Estado,  empresa);
        }
        public DataSet GuiaRemisionPendienteListarDS(DateTime fecha1, DateTime fecha2, String Serie, string Estado, string empresa)
        {
            return _GuiaRemisionPendienteDatos.GuiaRemisionPendienteListarDS(fecha1, fecha2, Serie, Estado, empresa);
        }
    } 


}
