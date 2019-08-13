using CapaEntidad;
using CapaDatos;
namespace CapaNegocio
{
    public class OpcionNegocio
    {
        OpcionDatos _OpcionDatos = new OpcionDatos();
        public OpcionEntidad OpcionConsultar(string user, string funcion)
        {
            return _OpcionDatos.OpcionConsultar(user, funcion);
        }
    }

}
