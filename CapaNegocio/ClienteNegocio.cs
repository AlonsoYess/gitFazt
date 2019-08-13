using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class ClienteNegocio
    {
        ClienteDatos _ClienteDatos = new ClienteDatos();
        public DataTable ClienteConsultar(string dato)
        {
            return _ClienteDatos.ClienteConsultar( dato);
        }
    }
}
