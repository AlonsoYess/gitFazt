namespace CapaEntidad
{
    public class ClienteDetalleDetEntidad
    {
        private string
        Codigo, Descripcion, Marca, Unidad, Cantidad, PrecioLista, PrecioSoles, SubtotalSoles;
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

        public string tbMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public string tbUnidad
        {
            get { return Unidad; }
            set { Unidad = value; }
        }
        public string tbCantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public string tbPrecioLista
        {
            get { return PrecioLista; }
            set { PrecioLista = value; }
        }

        public string tbPrecioSoles
        {
            get { return PrecioSoles; }
            set { PrecioSoles = value; }
        }
        public string tbSubtotalSoles
        {
            get { return SubtotalSoles; }
            set { SubtotalSoles = value; }
        }
    }
}
