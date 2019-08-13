using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SapDocAutorizadosNegocio
    {
        SapDocAutorizadosDatos _SapDocAutorizadosDatos = new SapDocAutorizadosDatos();
        public DataTable DocumentosAutorizadosConsultar(DateTime fechaInicial, DateTime fechaFinal, string numSAP, string codCliente, string codAlmacen)
        {
            return _SapDocAutorizadosDatos.DocumentosAutorizadosConsultar(fechaInicial, fechaFinal,  numSAP,  codCliente,codAlmacen);
        }
    }
}
