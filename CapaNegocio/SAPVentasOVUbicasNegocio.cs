using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPVentasOVUbicasNegocio
    {
        SAPVentasOVUbicasDatos _SAPVentasOVUbicasDatos = new SAPVentasOVUbicasDatos();
        public DataSet SAPVentasOVUbicasDS(string ca)
        {
            return _SAPVentasOVUbicasDatos.SAPVentasOVUbicasDS( ca);
        }
        public DataTable SAPVentasOVUbicasDT(string ca)
        {
            return _SAPVentasOVUbicasDatos.SAPVentasOVUbicasDT( ca);
        }

    }
}
