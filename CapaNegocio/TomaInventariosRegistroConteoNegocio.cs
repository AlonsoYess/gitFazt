using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TomaInventariosRegistroConteoNegocio
    {
        TomaInventariosRegistroConteoDatos _TomaInventariosRegistroConteoDatos = new TomaInventariosRegistroConteoDatos();
        public int TomaInventariosRegistrarConteo(int Numero, String Usuario, String Conteo, String Codigo, decimal Cantidad, DateTime Fecha, DateTime Hora, int Ubicacion)
        {
            return _TomaInventariosRegistroConteoDatos.TomaInventariosRegistrarConteo(Numero, Usuario, Conteo, Codigo, Cantidad, Fecha, Hora, Ubicacion);
        }

        public int TomaInventariosRegistrarConteoUpdate(int Numero, String Usuario, String Conteo, String Codigo, decimal Cantidad, DateTime Fecha, DateTime Hora, int Ubicacion)
        {
            return _TomaInventariosRegistroConteoDatos.TomaInventariosRegistrarConteoUpdate(Numero, Usuario, Conteo, Codigo, Cantidad, Fecha, Hora, Ubicacion);
        }

    } 


}
