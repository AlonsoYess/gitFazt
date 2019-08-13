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
    public partial class SAPVentasCliente : System.Web.UI.Page
    {
        SAPVentasClientesNegocio _SAPVentasClientesNegocio = new SAPVentasClientesNegocio();
        SAPVentasClientesEntidad _SAPVentasClientesEntidad = new SAPVentasClientesEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0;

        private void SAPVentasExportarExcel()
        {
            // Creamos el archivo
            String Nombre = "SAP"
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

            ew1.Cells["A1"].LoadFromDataTable(_SAPVentasClientesNegocio.VentasGeneralesDetalladaSAPDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text)), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }


        private void SAPVentasCarteraExcel()
        {
            // Creamos el archivo
            String Nombre = "SAP"
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

            ew1.Cells["A1"].LoadFromDataTable(_SAPVentasClientesNegocio.ClienteCartera(Convert.ToDateTime("2018-01-01"), Convert.ToDateTime(DateTime.Now.ToShortDateString())), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }else
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasCliente");
                if ((OpcionEnti.tbValor == 0))
                {

                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Total Ventas - Por Ultimos Clientes');window.location.href ='menup.aspx';</script>");
                }

                if (!Page.IsPostBack)
                {
                    txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                    DateTime FechaI = Convert.ToDateTime(txtFecha1.Text);

                    FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                    txtFecha1.Text = FechaI.ToString("yyyy-MM-dd");
                }
            }
            


            

            // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        private int validaFecha()
        {
            int resultado;
            DateTime dDate;

            if (DateTime.TryParse(txtFecha1.Text, out dDate) && DateTime.TryParse(txtFecha2.Text, out dDate))
            {
                resultado = 0;
            }
            else
            {
                resultado = 1;
            }


            return resultado;
        }
        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            if (validaFecha() == 1) { return; }
            SAPVentasExportarExcel();
        }

        protected void btnCarteraClientes_Click(object sender, EventArgs e)
        {

             SAPVentasCarteraExcel();
        }
    }
}