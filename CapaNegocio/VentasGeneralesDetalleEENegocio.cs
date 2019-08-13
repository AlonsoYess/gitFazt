using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class VentasGeneralesDetalleEENegocio
    {
        VentasGeneralesDetalleEEDatos _VentasGeneralesDetalleEEDatos = new VentasGeneralesDetalleEEDatos();
        public DataSet VentasGeneralesDetalleConsultarEEDS(DateTime f1, DateTime f2, string ca)
        {
            return _VentasGeneralesDetalleEEDatos.VentasGeneralesDetalleConsultarEEDS( f1,  f2,  ca);
        }
        public DataTable VentasGeneralesDetalleConsultarEEDT(DateTime f1, DateTime f2, string ca)
        {
            return _VentasGeneralesDetalleEEDatos.VentasGeneralesDetalleConsultarEEDT(f1, f2, ca);
        }

    }
}
