using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPVentasGeneralesDetalleNegocio
    {
        SAPVentasGeneralesDetalleDatos _SAPVentasGeneralesDetalleDatos = new SAPVentasGeneralesDetalleDatos();
        public DataSet VentasGeneralesDetalladaSAPDS(DateTime f1, DateTime f2, string ca)
        {
            return _SAPVentasGeneralesDetalleDatos.VentasGeneralesDetalladaSAPDS( f1,  f2,  ca);
        }
        public DataTable VentasGeneralesDetalladaSAPDT(DateTime f1, DateTime f2, string ca)
        {
            return _SAPVentasGeneralesDetalleDatos.VentasGeneralesDetalladaSAPDT(f1, f2, ca);
        }

    }
}
