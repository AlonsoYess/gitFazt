namespace CapaEntidad
{
    public class SAPVentasClientesEntidad
    {

        private string CodigoCliente,
                       NombreCliente,
                       Documento,
                       FechaCreacion,
                       Creador,
                       NroTrabajadores,
                       Rubro,
                       Score,
                       ScoreInicial,
                       ScoreLegal,
                       Segmentacion,
                       Observacion,
                       NroCoti,
                       NroDocs,
                       Total,
                       TotalMes;

        public string tbCodigoCliente
        {
            get { return CodigoCliente; }
            set { CodigoCliente = value; }
        }

        public string tbNombreCliente
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }

        public string tbDocumento
        {
            get { return Documento; }
            set { Documento = value; }
        }
        public string tbFechaCreacion
        {
            get { return FechaCreacion; }
            set { FechaCreacion = value; }
        }
        public string tbCreador
        {
            get { return Creador; }
            set { Creador = value; }
        }

        public string tbNroTrabajadores
        {
            get { return NroTrabajadores; }
            set { NroTrabajadores = value; }
        }

        public string tbRubro
        {
            get { return Rubro; }
            set { Rubro = value; }
        }

        public string tbScore
        {
            get { return Score; }
            set { Score = value; }
        }

        public string tbScoreInicial
        {
            get { return ScoreInicial; }
            set { ScoreInicial = value; }
        }

        public string tbScoreLegal
        {
            get { return ScoreLegal; }
            set { ScoreLegal = value; }
        }

        public string tbSegmentacion
        {
            get { return Segmentacion; }
            set { Segmentacion = value; }
        }

        public string tbObservacion
        {
            get { return Observacion; }
            set { Observacion = value; }
        }

        public string tbNroCoti
        {
            get { return NroCoti; }
            set { NroCoti = value; }
        }

        public string tbNroDocs
        {
            get { return NroDocs; }
            set { NroDocs = value; }
        }

        public string tbTotal
        {
            get { return Total; }
            set { Total = value; }
        }

        /*public string tbTotalMes
        {
            get { return TotalMes; }
            set { TotalMes = value; }
        }*/

    }
}
