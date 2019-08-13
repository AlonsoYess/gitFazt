using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class OrdenCompraNegocio
    {
        OrdenCompraDatos _OrdenCompraDatos = new OrdenCompraDatos();
        public DataTable OrdenCompraDT(DateTime fecha1, DateTime fecha2, string Empresa)
        {
            return _OrdenCompraDatos.OrdenCompraDT(fecha1, fecha2, Empresa);
        }
        public DataSet OrdenCompraDS(DateTime fecha1, DateTime fecha2, string Empresa)
        {
            return _OrdenCompraDatos.OrdenCompraDS(fecha1, fecha2, Empresa);
        }
    } 

}
