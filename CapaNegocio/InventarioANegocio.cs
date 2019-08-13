using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class InventarioANegocio
    {
        InventarioADatos _InventarioADatos = new InventarioADatos();
        public DataTable InventarioADT( String Conteo)
        {
            return _InventarioADatos.InventarioADT(Conteo);
        }
        public DataSet InventarioADS()
        {
            return _InventarioADatos.InventarioADS();
        }
    } 


}
