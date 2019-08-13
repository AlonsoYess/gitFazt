using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class VentasGeneralesDetalleNegocio
    {
        VentasGeneralesDetalleDatos _VentasGeneralesDetalleDatos = new VentasGeneralesDetalleDatos();
        public DataSet VentasGeneralesDetalleConsultarDS(DateTime f1, DateTime f2, string ca)
        {
            return _VentasGeneralesDetalleDatos.VentasGeneralesDetalleConsultarDS( f1,  f2,  ca);
        }
        public DataTable VentasGeneralesDetalleConsultarDT(DateTime f1, DateTime f2, string ca)
        {
            return _VentasGeneralesDetalleDatos.VentasGeneralesDetalleConsultarDT(f1, f2, ca);
        }

    }
}
