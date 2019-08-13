using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TEstadoNegocio
    {
        TEstadoDatos _TEstadoDatos = new TEstadoDatos();
        public DataTable TomaIEstadosDT()
        {
            return _TEstadoDatos.TomaIEstadosDT();
        }
        public DataSet TomaIEstadosDS()
        {
            return _TEstadoDatos.TomaIEstadosDS();
        }
    } 


}
