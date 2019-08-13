using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TEstadoDetalleNegocio
    {
        TEstadoDetalleDatos _TEstadoDetalleDatos = new TEstadoDetalleDatos();
        public DataTable TomaIEstadosDetalleDT(int nInventario)
        {
            return _TEstadoDetalleDatos.TomaIEstadosDetalleDT(nInventario);
        }
        public DataSet TomaIEstadosDetalleDS(int nInventario)
        {
            return _TEstadoDetalleDatos.TomaIEstadosDetalleDS(nInventario);
        }
    } 


}
