using System;

namespace CapaEntidad
{
    public class VentaGEntidad
    {
        private DateTime FechaEm;
        private string EmpCod, Ruc, Razon, Doc, NroDoc, TipoCambio, Moneda, VenCod, VenDes, TipoPago, TipoDes, VendedorSS, VendedorCC;
        private decimal Total, Igv;
        

        public DateTime tbFechaEm
        {
            get { return FechaEm; }
            set { FechaEm = value; }
        }
        public string tbEmpCod
        {
            get { return EmpCod; }
            set { EmpCod = value; }
        }
        public string tbRuc
        {
            get { return Ruc; }
            set { Ruc= value; }
        }
        public string tbRazon
        {
            get { return Razon; }
            set { Razon = value; }
        }
        public string tbDoc
        {
            get { return Doc; }
            set { Doc = value; }
        }
        public string tbNroDoc
        {
            get { return NroDoc; }
            set { NroDoc = value; }
        }
        public string tbTipoCambio
        {
            get { return TipoCambio; }
            set { TipoCambio = value; }
        }
        public string tbMoneda
        {
            get { return Moneda; }
            set { Moneda = value; }
        }
        public string tbVenCod
        {
            get { return VenCod; }
            set { VenCod = value; }
        }
        public string tbVenDes
        {
            get { return VenDes; }
            set { VenDes = value; }
        }
        public string tbTipoPago
        {
            get { return TipoPago; }
            set { TipoPago = value; }
        }
        public string tbTipoDes
        {
            get { return TipoDes; }
            set { TipoDes = value; }
        }
        public string tbVendedorSS
        {
            get { return VendedorSS; }
            set { VendedorSS = value; }
        }
        public string tbVendedorCC
        {
            get { return VendedorCC; }
            set { VendedorCC = value; }
        }
        public decimal tbTotal
        {
            get { return Total; }
            set { Total = value; }
        }
        public decimal tbIgv
        {
            get { return Igv; }
            set { Igv = value; }
        }
    }
}
