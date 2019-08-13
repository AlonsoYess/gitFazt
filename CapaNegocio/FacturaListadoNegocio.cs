using System.Data;
using CapaDatos;
using System;

namespace CapaNegocio
{
    public class FacturaListadoNegocio
    {
        FacturaListadoDatos _FacturaListadoDatos = new FacturaListadoDatos();
        public DataTable FacturaListadoConsultarDT( DateTime fei, DateTime fev, string emp, string pun)
        {
            return _FacturaListadoDatos.FacturaListadoConsultarDT(fei, fev, emp, pun);
        }

        public DataSet FacturaListadoConsultarDS(DateTime fei, DateTime fev, string emp, string pun)
        {
            return _FacturaListadoDatos.FacturaListadoConsultarDS(fei, fev, emp, pun);
        }
    }
}

