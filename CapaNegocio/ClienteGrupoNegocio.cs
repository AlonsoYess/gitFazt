using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class ClienteGrupoNegocio
    {
        ClienteGrupoDatos _ClienteGrupoDatos = new ClienteGrupoDatos();
        public DataTable ClienteGrupoConsultar(string dato, string fecha1, string fecha2)
        {
            return _ClienteGrupoDatos.ClienteGrupoConsultar(dato, fecha1, fecha2);
        }
    } 


}
