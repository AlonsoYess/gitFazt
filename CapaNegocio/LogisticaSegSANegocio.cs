using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class LogisticaSegSANegocio
    {
        LogisticaSegSADatos _LogisticaSegSADatos = new LogisticaSegSADatos();
        public DataTable LogisticaSegSAListar(string fecha1, string fecha2, string almacen, string empresa)
        {
            return _LogisticaSegSADatos.LogisticaSegSAListar(fecha1, fecha2, almacen, empresa);
        }
    }


}
