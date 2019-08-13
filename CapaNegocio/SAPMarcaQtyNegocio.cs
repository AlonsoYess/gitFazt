using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class SAPMarcaQtyNegocio
    {
        SAPMarcaQtyDatos _SAPMarcaQtyDatos = new SAPMarcaQtyDatos();
        public DataTable SAPMarcaQtyDS()
        {
            return _SAPMarcaQtyDatos.SAPMarcaQtyDS();
        }
    } 
}
