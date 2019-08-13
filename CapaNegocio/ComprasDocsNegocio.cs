using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ComprasDocsNegocio
    {
        ComprasDocsDatos _ComprasDocsDatos = new ComprasDocsDatos();
        public DataTable ComprasDocsDT(DateTime  fecha1, DateTime  fecha2,string empresa)
        {
            return _ComprasDocsDatos.ComprasDocsDT(fecha1, fecha2,empresa);
        }
        public DataSet ComprasDocsDS(DateTime  fecha1, DateTime  fecha2, string empresa)
        {
            return _ComprasDocsDatos.ComprasDocsDS(fecha1, fecha2, empresa);
        }
    } 


}
