using System;

namespace CapaEntidad
{
    public class DocEntidad
    {
        private string VendedorCod, RazonSocial, ClienteRUC, Direccion, FormaPagoDes, Doc, Moneda, ProductoCod, ProductoDes, Unidad, Empresa;

        private DateTime FechaE;

        private Decimal ClienteCod,Nro,Importe,Impuesto,Cantidad,Precio,Descuento,Total,Descto,Subtotal;

        private int FormaPagoCod;

        public string tbEmpresa
        {
            get { return Empresa; }
            set { Empresa = value; }
        }

        public string tbVendedorCod
        {
            get { return VendedorCod; }
            set { VendedorCod = value; }
        }
         public DateTime tbFechaE
        {
            get { return FechaE; }
            set { FechaE = value; }
        }

        public Decimal tbClienteCod
        {
            get { return ClienteCod; }
            set { ClienteCod = value; }
        }
        public string tbClienteRUC
        {
            get { return ClienteRUC; }
            set { ClienteRUC = value; }
        }

        public string tbRazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }
        public string tbdireccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public int tbFormaPagocod
        {
            get { return FormaPagoCod; }
            set { FormaPagoCod = value; }
        }
        public string tbFormaPagoDes
        {
            get { return FormaPagoDes; }
            set { FormaPagoDes = value; }
        }
        public string tbDoc
        {
            get { return Doc; }
            set { Doc = value; }
        }
        public Decimal tbNro
        {
            get { return Nro; }
            set { Nro = value; }
        }
        public string tbMoneda
        {
            get { return Moneda; }
            set { Moneda = value; }
        }
        public Decimal tbImporte
        {
            get { return Importe; }
            set { Importe = value; }
        }
        public Decimal tbImpuesto
        {
            get { return Impuesto; }
            set { Impuesto = value; }
        }
        public string tbProductoCod
        {
            get { return ProductoCod; }
            set { ProductoCod = value; }
        }
        public string tbProductoDes
        {
            get { return ProductoDes; }
            set { ProductoDes = value; }
        }
        public string tbUnidad
        {
            get { return Unidad; }
            set { Unidad = value; }
        }
        public Decimal tbCantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public Decimal tbPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public Decimal tbDescuento
        {
            get { return Descuento; }
            set { Descuento = value; }
        }
        public Decimal tbTotal
        {
            get { return Total; }
            set { Total = value; }
        }
        public Decimal tbDescto
        {
            get { return Descto; }
            set { Descto = value; }
        }
        public Decimal tbSubtotal
        {
            get { return Subtotal; }
            set { Subtotal = value; }
        }
    }

    public class MontoLetrasEntidad
    {
        private string LetraMonto;
        public string tbMonto
        {
            get { return LetraMonto; }
            set { LetraMonto = value; }
        }
    }

}


