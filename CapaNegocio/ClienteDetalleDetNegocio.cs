using System.Data;
using CapaDatos;
using System;

namespace CapaNegocio
{
    public class ClienteDetalleDetNegocio
    {
        ClienteDetalleDetDatos _ClienteDetalleDetDatos = new ClienteDetalleDetDatos();
        public DataTable ClienteDetalleConsultarDET(string v1, string v2, string v3, string v4, string v5)
        {
            return _ClienteDetalleDetDatos.ClienteDetalleConsultarDET(v1, v2, v3, v4,v5);
        }
    }
}
