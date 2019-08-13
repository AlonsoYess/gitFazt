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
    public partial class SAPCostoIn : System.Web.UI.Page
    {

        SAPCostosInventarioNegocio SAPCostosInventarioNegocio = new SAPCostosInventarioNegocio();



        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0;
        string cliente = string.Empty;
        string canal = string.Empty;

        private void costoInventarioExcel()
        {
            // Creamos el archivo
            String Nombre = "CostoInventario"
            + Convert.ToString(DateTime.Now.Day)
            + Convert.ToString(DateTime.Now.Month)
            + Convert.ToString(DateTime.Now.Year)
            + Convert.ToString(DateTime.Now.Hour)
            + Convert.ToString(DateTime.Now.Minute)
            + Convert.ToString(DateTime.Now.Second) + ".xlsx";

            String RutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\" + Nombre;

            String RutadeArchivo = @RutaArchivo;

            ExcelPackage ep = new ExcelPackage(new FileInfo(RutadeArchivo));

            //Le añadimos los 'worksheets' que necesitemos.
            //En este caso añadiremos solo uno
            ep.Workbook.Worksheets.Add("Sico");

            //Creamos un objecto tipo ExcelWorksheet para
            //manejarlo facilmente.
            ExcelWorksheet ew1 = ep.Workbook.Worksheets[1];
            validacion();
            ew1.Cells["A1"].LoadFromDataTable(SAPCostosInventarioNegocio.VentasGeneralesDetalleConsultarDT(Convert.ToDateTime(txtFechaInicial.Text), Convert.ToDateTime(txtFecha2.Text),cliente,ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "CostoInventario");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso ');window.location.href ='menup.aspx';</script>");
            }

            if (!Page.IsPostBack)
            {
                //Text = DateTime.Now.ToString("yyyy-MM-dd");

                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = DateTime.Now;

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFechaInicial.Text = FechaI.ToString("yyyy-MM-dd");
            }
        }

        private int validaFecha()
        {
            int resultado;
            DateTime dDate;

            if (DateTime.TryParse(txtFechaInicial.Text, out dDate) && DateTime.TryParse(txtFecha2.Text, out dDate))
            {
                resultado = 0;
            }
            else
            {
                resultado = 1;
            }


            return resultado;
        }
        private void validacion()
        {

            if (txtRuc.Text == "")
            {
                cliente = "0";
            }
            else
            {
                cliente = txtRuc.Text;
            }
            
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaFecha() == 1) { return; }
                costoInventarioExcel();
            }catch(Exception)
            {
                throw new Exception();
            }
            
        }
    }
}