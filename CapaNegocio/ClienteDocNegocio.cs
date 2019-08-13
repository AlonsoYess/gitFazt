using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class ClienteDocNegocio
    {
        ClienteDocDatos _ClienteDocDatos = new ClienteDocDatos();
        public DataTable ClienteDocConsultar(string empresa, string ruc, string doc, string nro)
        {
            return _ClienteDocDatos.ClienteDocConsultar(empresa,  ruc,  doc,  nro);
        }
    }
}
