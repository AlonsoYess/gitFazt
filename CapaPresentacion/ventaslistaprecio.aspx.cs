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
    public partial class ventaslistaprecio : System.Web.UI.Page
    {

        SAPListaPrecioStockNegocio SAPListaPrecioStockNego = new SAPListaPrecioStockNegocio();
        SAPListaPrecioStockEntidad SAPListaPrecioStockEnti = new SAPListaPrecioStockEntidad();


        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0;

        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = SAPListaPrecioStockNego.SapListaPrecioDT();
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
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ventaslistaprecio");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("SAPListaPrecioDetalle.aspx?datos1=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text + "&datos2=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[1].Text);

                /*Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() 
                    + "&datos2=" + Label2.Text.ToString()
                    + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text 
                    + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text 
                    + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);*/
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ventaslistaprecio');</script>");
                Response.Redirect("sico.aspx");
            }

        }
    }
}