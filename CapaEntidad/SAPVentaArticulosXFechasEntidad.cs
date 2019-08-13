using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class SAPVentaArticulosXFechasEntidad
    {
        private string CodigoArticulo, CodigoMarca, DescripcionMarca, CodigoLinea, DescripcionLinea, NombreArticulo, Total;
        public string tbCodigoArticulo
        {
            get { return CodigoArticulo; }
            set { CodigoArticulo = value; }
        }

        public string tbCodigoMarca
        {
            get { return CodigoMarca; }
            set { CodigoMarca = value; }
        }

        public string tbDescripcionMarca
        {
            get { return DescripcionMarca; }
            set { DescripcionMarca = value; }
        }

        public string tbCodigoLinea
        {
            get { return CodigoLinea; }
            set { CodigoLinea = value; }
        }

        public string tbDescripcionLinea
        {
            get { return DescripcionLinea; }
            set { DescripcionLinea = value; }
        }

        public string tbNombreArticulo
        {
            get { return NombreArticulo; }
            set { NombreArticulo = value; }
        }

        public string tbTotal
        {
            get { return Total; }
            set { Total = value; }
        }

    }
}
