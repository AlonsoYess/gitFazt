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
    public partial class SAPVentasXArticuloExcel : System.Web.UI.Page
    {
        SAPVentaArticulosXFechasNegocio ventasFechaArticuloNego = new SAPVentaArticulosXFechasNegocio();
        SAPVentaArticulosXFechasEntidad ventasFechaArticuloEnti = new SAPVentaArticulosXFechasEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

       

        private void VentasExportarExcel()
        {
            // Creamos el archivo
                String Nombre = "SAPVentasXArticulo"
                + Convert.ToString(DateTime.Now.Day )
                + Convert.ToString(DateTime.Now.Month )
                + Convert.ToString(DateTime.Now.Year )
                + Convert.ToString(DateTime.Now.Hour )
                + Convert.ToString(DateTime.Now.Minute )
                + Convert.ToString(DateTime.Now.Second) + ".xlsx";

            String RutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\" + Nombre ;

            String RutadeArchivo = @RutaArchivo;
            
            ExcelPackage ep = new ExcelPackage(new FileInfo(RutadeArchivo));

            //Le añadimos los 'worksheets' que necesitemos.
            //En este caso añadiremos solo uno
            ep.Workbook.Worksheets.Add("Sico");

            //Creamos un objecto tipo ExcelWorksheet para
            //manejarlo facilmente.
            ExcelWorksheet ew1 = ep.Workbook.Worksheets[1];

            ew1.Cells["A1"].LoadFromDataTable(ventasFechaArticuloNego.VentaArticulosXFechasSAPDT(Convert.ToDateTime(txtFechaInicial.Text), Convert.ToDateTime(txtFechaFinal.Text)), true);

            ep.Save();
            Response.Redirect("/" + Nombre );

        }

        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            

            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }else
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VenXFecArt");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Ventas X Fecha y Articulo');window.location.href ='menup.aspx';</script>");
            }
            }

            if (!Page.IsPostBack)
            {
                txtFechaInicial.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFechaFinal.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = Convert.ToDateTime(txtFechaInicial.Text);

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFechaInicial.Text = FechaI.ToString("yyyy-MM-dd");
            }


            

           // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        protected void btnVentaPBuscar0_Click(object sender, EventArgs e)
        {

                if (validaFecha()==1) { return; }
                VentasExportarExcel();
             
        }

        private int validaFecha()
        {
            int resultado;
            DateTime dDate;

            if (DateTime.TryParse(txtFechaInicial.Text, out dDate) && DateTime.TryParse(txtFechaFinal.Text, out dDate))
            {
                if (DateTime.Compare(Convert.ToDateTime(txtFechaInicial.Text), Convert.ToDateTime(txtFechaFinal.Text)) > 0 )
                {
                    resultado = 1;
                }else
                {
                    resultado = 0;
                }
            }
            else
            {
                resultado = 1;
                
            }


            return resultado;
        }
    }
}