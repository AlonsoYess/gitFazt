using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class SAPVentaArticulosXFechasNegocio
    {
        SAPVentaArticulosXFechasDatos _SAPVentaArticulosXFechasDatos = new SAPVentaArticulosXFechasDatos();
        public DataSet VentaArticulosXFechasSAPDS(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _SAPVentaArticulosXFechasDatos.VentasGeneralesDetalladaSAPDS(fechaInicial, fechaFinal);
        }
        public DataTable VentaArticulosXFechasSAPDT(DateTime fechaInicial, DateTime fechaFinal)
        {
            return _SAPVentaArticulosXFechasDatos.VentasGeneralesDetalladaSAPDT(fechaInicial, fechaFinal);
        }
    }
}
