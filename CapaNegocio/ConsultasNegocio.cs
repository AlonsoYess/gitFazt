using System;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ConsultasNegocio
    {
        ConsultasDatos _ConsultasDatos = new ConsultasDatos();
        public ConsultasEntidad AlmacenCodigo()
        {
            return _ConsultasDatos.AlmacenCodigo();
        }

        public invConteoEntidad invConteo(int Numero, String Usuario, String Conteo, String Codigo, decimal Cantidad, DateTime Fecha, DateTime Hora, int Ubicacion)
        {
            return _ConsultasDatos.invConteo( Numero,  Usuario,  Conteo,  Codigo,  Cantidad,  Fecha,  Hora,  Ubicacion);
        }







    }


}
