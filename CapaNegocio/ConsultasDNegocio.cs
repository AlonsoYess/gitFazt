using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ConsultasDNegocio
    {
        ConsultasDDatos _ConsultasDDatos = new ConsultasDDatos();
        public ConsultasDEntidad ProductoDatos(string Codigo)
        {
            return _ConsultasDDatos.ProductoDatos(Codigo);
        }






    } 


}
