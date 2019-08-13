using System;
using CapaNegocio;
using CapaEntidad;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI.HtmlControls;
using SpreadsheetLight;
using ExcelLibrary.SpreadSheet;
using OfficeOpenXml;

namespace CapaPresentacion
{
    public partial class StockXMarca : System.Web.UI.Page
    {


        SapStockXMarcaNegocio SapStockXMarcaNegocio = new SapStockXMarcaNegocio();

        SAPMarcaQtyNegocio SAPMarcaQtyNego = new SAPMarcaQtyNegocio();
        SAPMarcaQtyEntidad SAPMarcaQtyEnti = new SAPMarcaQtyEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0;

        private void VentasListaExportarExcel()
        {
            // Creamos el archivo
            String Nombre = "ListaSAP"
            + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text
            + Convert.ToString(DateTime.Now.Day)
            + Convert.ToString(DateTime.Now.Month)
            + Convert.ToString(DateTime.Now.Year)
            + Convert.ToString(DateTime.Now.Hour)
            + Convert.ToString(DateTime.Now.Minute)
            + Convert.ToString(DateTime.Now.Second) + ".xlsx";

            String RutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\" + Nombre;
            String RutadeArchivo = @RutaArchivo;

            ExcelPackage ep = new ExcelPackage(new FileInfo(RutadeArchivo));

            ep.Workbook.Worksheets.Add("Sico");

            ExcelWorksheet ew1 = ep.Workbook.Worksheets[1];
            ew1.Cells["A1"].LoadFromDataTable(SapStockXMarcaNegocio.SAPListaPrecioStockDT(this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text), true);
            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = SAPMarcaQtyNego.SAPMarcaQtyDS();
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ventaslistaprecio");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Lista de Precios - ventaslistaprecio');window.location.href ='menup.aspx';</script>");
            }

            if (!Page.IsPostBack)
            {
                VentasGCListarPL();
            }
        }

        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text
            VentasListaExportarExcel();

        }
    }
}