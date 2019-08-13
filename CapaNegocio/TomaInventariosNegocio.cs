using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class TomaInventariosNegocio
    {
        TomaInventariosDatos _TomaInventariosDatos = new TomaInventariosDatos();
        public int TomaInventariosInsertar(int Numero, DateTime Fecha, String Usuario, String Responsable, DateTime FechaInicio, DateTime FechaFinal, String Almacen, String Estado, String Observaciones)
        {
            return _TomaInventariosDatos.TomaInventariosInsertar( Numero,  Fecha,  Usuario,  Responsable,  FechaInicio,  FechaFinal,  Almacen,  Estado,  Observaciones);
        }

    } 


}
