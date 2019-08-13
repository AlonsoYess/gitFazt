using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CompraNPNegocio
    {
        CompraNPDatos _CompraNPDatos = new CompraNPDatos();
        public DataTable CompraNPListar(string Empre, string notap, string orden)
        {
            return _CompraNPDatos.CompraNPListar(Empre,  notap,  orden);
        }
    }
}
