using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class AlmacenNegocio
    {
        AlmacenDatos _AlmacenDatos = new AlmacenDatos();
        public DataTable AlmacenDT()
        {
            return _AlmacenDatos.AlmacenDT();
        }
        public DataSet AlmacenDS()
        {
            return _AlmacenDatos.AlmacenDS();
        }
    } 


}
