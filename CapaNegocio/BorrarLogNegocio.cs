using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class BorrarLogNegocio
    {
        BorrarLogDatos _BorrarLogDatos = new BorrarLogDatos();
        public int BorrarLog()
        {
            int valor = _BorrarLogDatos.BorrarLog();
            return valor;
        }
    }
}
