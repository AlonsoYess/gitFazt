using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Imprimir : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoCapas"].ConnectionString);
        DataTable DocEnti = new DataTable();
        DocNegocio DocNego = new DocNegocio();
        ReportDocument report = new ReportDocument();
        string Monto;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string nombreempresa = Session["NomEmp"].ToString();
            string tipodocumento = Session["TipoDoc"].ToString();
            string numerofactura = Session["NroFac"].ToString();

            DocEnti = DocNego.DocConsultar(nombreempresa, tipodocumento, numerofactura);
            //report.ParameterFields.Add(new SqlParameter("montoletras",Monto));
            report.Load(Server.MapPath("rptcomprobante.rpt"));
            report.SetDataSource(DocEnti);
            crptvisor1.ReportSource = report;
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            report.PrintToPrinter(1, false, 0, 0);
        }
    }
}