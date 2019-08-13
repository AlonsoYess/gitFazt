using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class UserNegocio
    {
        UserDatos _UserDatos = new UserDatos();
        public UserEntidad UserConsultar(string user, string clave)
        {
            return _UserDatos.UserConsultar( user,  clave);
        }
    }
}
