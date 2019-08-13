namespace CapaEntidad
{
    public class SAPStockxProductoEntidad
    {

        private string Empresa, Codigo, Descripcion, AlmacenCod, AlmacenNom, Unidad, Stock,Disponible, PrecioSol, PrecioSol1, PrecioSol2, PrecioSol3;

        public string tbEmpresa
        {
            get { return Empresa; }
            set { Empresa = value; }
        }
        public string tbCodigo
        {
        get { return Codigo; }
        set { Codigo = value; }
    }

    public string tbDescripcion
        {
        get { return Descripcion; }
        set { Descripcion = value; }
    }

    public string tbAlmacenCod
        {
        get { return AlmacenCod; }
        set { AlmacenCod = value; }
    }

        public string tbAlmacenNom
        {
            get { return AlmacenNom; }
            set { AlmacenNom = value; }
        }
        public string tbUnidad
        {
            get { return Unidad; }
            set { Unidad = value; }
        }
        public string tbStock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public string tbDisponible
        {
            get { return Disponible; }
            set { Disponible = value; }
        }
        public string tbPrecioSol
        {
            get { return PrecioSol; }
            set { PrecioSol = value; }
        }
    }
}
