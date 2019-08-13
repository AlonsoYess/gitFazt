using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class DocNegocio
    {
        DocDatos _DocDatos = new DocDatos();
        public DataTable DocConsultar(string emp,string tipodoc, string numfac)
        {
            return _DocDatos.DocConsultar(emp,tipodoc, numfac);
        }
  

    }
}
