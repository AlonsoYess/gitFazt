
using System;

namespace CapaEntidad
{
    public class LogisticaSegSAEntidad
    {
        private DateTime Fecha;
        private string Doc, NroDoc, Ruc, RazonSocial, GuiaRemisionDoc, GuiaRemisionNro, NotaPedidoNro, MovimientoSalidaDoc, MovimientoSalidaNro, EstadoMovimiento;
                    // Doc, NroDoc, Ruc, RazonSocial, GuiaRemisionDoc, GuiaRemisionNro, NotaPedidoNro, MovimientoSalidaDoc, MovimientoSalidaNro, EstadoMovimiento


        public DateTime tbFecha
        {
            get { return Fecha; }
            set { Fecha = value; }
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
        public string tbRuc
        {
            get { return Ruc; }
            set { Ruc = value; }
        }
        public string tbRazonSocial
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }
        public string tbGuiaRemisionDoc
        {
            get { return GuiaRemisionDoc; }
            set { GuiaRemisionDoc = value; }
        }
        public string tbGuiaRemisionNro
        {
            get { return GuiaRemisionNro; }
            set { GuiaRemisionNro = value; }
        }
        public string tbNotaPedidoNro
        {
            get { return NotaPedidoNro; }
            set { NotaPedidoNro = value; }
        }
        public string tbMovimientoSalidaDoc
        {
            get { return MovimientoSalidaDoc; }
            set { MovimientoSalidaDoc = value; }
        }
        public string tbMovimientoSalidaNro
        {
            get { return MovimientoSalidaNro; }
            set { MovimientoSalidaNro = value; }
        }
        public string tbEstadoMovimiento
        {
            get { return EstadoMovimiento; }
            set { EstadoMovimiento = value; }
        }
      
    }
}
