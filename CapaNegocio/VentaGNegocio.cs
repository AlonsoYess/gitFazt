using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class VentaGNegocio
    {
        VentaGDatos _VentaGDatos = new VentaGDatos();
        public DataTable VentasGConsultar( String fechaI, String fechaF)
        {
            return _VentaGDatos.VentasGConsultar(fechaI, fechaF);
        }

    }
}
