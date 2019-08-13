using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CompraNegocio
    {
        CompraDatos _CompraDatos = new CompraDatos();
        public DataTable CompraCotizListar(string cotiz, string orden)
        {
            return _CompraDatos.CompraCotizListar(cotiz, orden);
        }
    }
}
