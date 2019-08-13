using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TomaInventariosAutorizarNegocio
    {
        TomaInventariosAutorizarDatos _TomaInventariosAutorizarDatos = new TomaInventariosAutorizarDatos();
        public int TomaInventariosActualizar(int Numero, String Usuario, DateTime FechaInicio, DateTime FechaFinal, String EstadoA, String EstadoN, String ConteoN)
        {
            return _TomaInventariosAutorizarDatos.TomaInventariosActualizar( Numero,  Usuario,  FechaInicio,  FechaFinal,  EstadoA,  EstadoN, ConteoN);
        }

    } 


}
