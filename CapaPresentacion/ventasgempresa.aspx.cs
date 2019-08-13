using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CapaNegocio;





namespace CapaPresentacion
{
    public partial class ventasgempresa : System.Web.UI.Page
    {
        
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoCapas"].ConnectionString);
        DataTable VentaGEnti = new DataTable();
        VentaGNegocio VentaGNego = new VentaGNegocio();
        ReportDocument reporteVentaG = new ReportDocument();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //CrystalReportViewer1.Visible = true;
            reporteVentaG.Load(Server.MapPath("rVentasEmpresaGenerales.rpt"));
            reporteVentaG.SetParameterValue("@feci", TextBox1.Text);
            reporteVentaG.SetParameterValue("@fecf", TextBox3.Text);
            reporteVentaG.SetDatabaseLogon("SOPORTE", "SOPORTE", "180.100.0.140", "SICOWEB");
   
            CrystalReportViewer1.ReportSource = reporteVentaG;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            CrystalReportViewer1.Visible = false;

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            
            CrystalReportViewer1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CrystalReportViewer1.Visible = true;
            reporteVentaG.Load(Server.MapPath("rVentasEmpresaGenerales.rpt"));
            reporteVentaG.SetDatabaseLogon("SOPORTE", "SOPORTE", "180.100.0.202", "SICOWEB");
            reporteVentaG.SetParameterValue("@feci",TextBox1.Text);
            reporteVentaG.SetParameterValue("@fecf", TextBox3.Text);
      

            CrystalReportViewer1.ReportSource = reporteVentaG;

      

        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {/*
            CrystalReportViewer1.Visible = true;
            reporteVentaG.Load(Server.MapPath("rVentasEmpresaGenerales.rpt"));
            reporteVentaG.SetParameterValue("@feci", TextBox1.Text);
            reporteVentaG.SetParameterValue("@fecf", TextBox3.Text);
            reporteVentaG.SetDatabaseLogon("SOPORTE", "SOPORTE", "180.100.0.9", "SICOWEB");
            //reporteVentaG.SetDataSource(VentaGEnti);

            /*CrystalReportViewer1.ParameterFieldInfo = fis;
            CrystalReportViewer1.ParameterFieldInfo = ffs;*/
            //CrystalReportViewer1.ReportSource = reporteVentaG;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            VentaGEnti = VentaGNego.VentasGConsultar(TextBox1.Text, TextBox3.Text);
            CrystalReportViewer1.Visible = true;
            reporteVentaG.Load(Server.MapPath("rVentasEmpresaGenerales.rpt"));
            reporteVentaG.SetDataSource(VentaGEnti);
            CrystalReportViewer1.ReportSource = reporteVentaG;

            reporteVentaG.ExportToHttpResponse(ExportFormatType.Excel, Response, true, "rVentasEmpresaGenerales");
            Response.End();
        }
    }
}