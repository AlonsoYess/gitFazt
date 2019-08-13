using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPVentasGeneralesDetalleEENegocio
    {
        SAPVentasGeneralesDetalleEEDatos _SAPVentasGeneralesDetalleEEDatos = new SAPVentasGeneralesDetalleEEDatos();
        public DataSet VentasGeneralesDetalladaSAPEEDS(DateTime f1, DateTime f2, string ca)
        {
            return _SAPVentasGeneralesDetalleEEDatos.VentasGeneralesDetalladaSAPEEDS( f1,  f2,  ca);
        }
        public DataTable VentasGeneralesDetalladaSAPEEDT(DateTime f1, DateTime f2, string ca)
        {
            return _SAPVentasGeneralesDetalleEEDatos.VentasGeneralesDetalladaSAPEEDT(f1, f2, ca);
        }

    }
}
