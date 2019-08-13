using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SAPQuiebreStock : System.Web.UI.Page
    {
       
        SAPQuiebreStockNegocio SAPQuiebreStockNegocio = new SAPQuiebreStockNegocio();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "QuiebreStock");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso  - QuiebreStock');window.location.href ='menup.aspx';</script>");
            }
            ListarDatos();
        }

        protected void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            
                SAPQuiebreStockExcel();
            
        }

        private void ListarDatos()
        {
            /*try
            {*/
                grdListado.DataSource = SAPQuiebreStockNegocio.QuiebreStockPDT();
                grdListado.DataBind();

            /*}
            catch (Exception)
            {
                throw new Exception();
            }*/
        }

        private void SAPQuiebreStockExcel()
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

            ew1.Cells["A1"].LoadFromDataTable(SAPQuiebreStockNegocio.QuiebreStockPDT(), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }

        protected void grdListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdListado.PageIndex = e.NewPageIndex;
            ListarDatos();
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           string TextToSearch = txtBuscar.Text;
            if (TextToSearch != "") {
                BindingSource bs = new BindingSource();
                bs.DataSource = SAPQuiebreStockNegocio.QuiebreStockPDT();
                //bs.DataSource = grdListado.Page;
                bs.Filter = $"[CODIGOARTICULO] LIKE '%{TextToSearch}%'";
                grdListado.DataSource = bs;
                grdListado.DataBind();
                
           }
            else
            {
                grdListado.DataSource = SAPQuiebreStockNegocio.QuiebreStockPDT();
                grdListado.DataBind();
            }
        }

        protected void grdListado_PageIndexChanged(object sender, EventArgs e)
        {

        }
    }
}