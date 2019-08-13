using System.Data;
using CapaDatos;
using System;
namespace CapaNegocio
{
    public class SAPCostosInventarioNegocio
    {
        SapCostosInventarioDatos _SapCostosInventarioDatos = new SapCostosInventarioDatos();
        public DataSet VentasGeneralesDetalleConsultarDS(DateTime FechaInicio, DateTime FechaFin, string CodCliente, string Canal)
        {
            return _SapCostosInventarioDatos.CostoInvetarioDS(FechaInicio, FechaFin, CodCliente, Canal);
        }
        public DataTable VentasGeneralesDetalleConsultarDT(DateTime FechaInicio, DateTime FechaFin, string CodCliente, string Canal)
        {
            return _SapCostosInventarioDatos.CostoInvetarioDSDT(FechaInicio, FechaFin, CodCliente, Canal);
        }

    }
}
