using System;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class NotaPedidoListadoNegocio
    {
        NotaPedidoListadoDatos _NotaPedidoListadoDatos = new NotaPedidoListadoDatos();
        public DataTable NotaPedidoListadoConsultarDT(DateTime  feci, DateTime fecf, string alma, string nota)
        {
            return _NotaPedidoListadoDatos.NotaPedidoListadoConsultarDT( feci,  fecf, alma,  nota);
        }

        public DataSet NotaPedidoListadoConsultarDS(DateTime  feci, DateTime  fecf, string alma, string nota)
        {
            return _NotaPedidoListadoDatos.NotaPedidoListadoConsultarDS(feci, fecf, alma, nota);
        }
    }
}

