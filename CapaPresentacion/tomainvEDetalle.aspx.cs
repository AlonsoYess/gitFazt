using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using OfficeOpenXml;
using System.IO;
using System.Web.UI.WebControls;


namespace CapaPresentacion
{
    public partial class tomainvEDetalle : System.Web.UI.Page
    {


        TomaInventariosAutorizarNegocio TEstadoActualizarNego = new TomaInventariosAutorizarNegocio();

        TomaInventarioReporteNegocio TomaInventarioReporteNego = new TomaInventarioReporteNegocio();
        TomaInventarioReporteEntidad TomaInventarioReporteEnti = new TomaInventarioReporteEntidad();

        TEstadoDetalleNegocio TEstadoDetalleNego = new TEstadoDetalleNegocio();
        TEstadoDetalleEntidad TEstadoEnti = new TEstadoDetalleEntidad();



        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        //Double suma = 0 ;
        int NroInv;
        string EstInv = "";

        private void TInventarioGExportarExcel()
        {
            // Creamos el archivo
            String Nombre = "ResporteSicoNet"
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

            ew1.Cells["A1"].LoadFromDataTable(TomaInventarioReporteNego.TomaInventarioReporteDT(lblInventario.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            NroInv = Convert.ToInt16(Request.QueryString["datos1"]);
            EstInv = Request.QueryString["datos1"];

            lblInventario.Text = Request.QueryString["datos1"];
            lblEInventario.Text = Request.QueryString["datos2"];

            //VentasGCListarPL();
            if (!Page.IsPostBack)
            {
                //txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
    
            }


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            //VentasGCListarPL();
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            /*OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {

                VentasGCListarPL();

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");
            }*/
                
        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           /* e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                suma = suma + Convert.ToDouble(e.Row.Cells[2].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[1].Text = "Total :";
                    e.Row.Cells[2].Text = suma.ToString("N");
                    e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
                    

                }
                    
            }*/
                     
        }
         
        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "999")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TEstadoActualizarNego.TomaInventariosActualizar (
                Convert.ToInt16 (lblInventario.Text) ,
                Session["rusiausuario"].ToString(),
                DateTime.Now,
                DateTime.Now.ToLocalTime(),
                lblEInventario.Text ,
                "Autorizado",
                ddlConteo.Text 
                );
            Response.Redirect("tomainvEstados.aspx");
        }

        protected void btnTomaInvCerrar_Click(object sender, EventArgs e)
        {
            TEstadoActualizarNego.TomaInventariosActualizar(
                Convert.ToInt16(lblInventario.Text),
                Session["rusiausuario"].ToString(),
                DateTime.Now,
                DateTime.Now.ToLocalTime(),
                lblEInventario.Text,
                "Cerrado",
                ddlConteo.Text
                );
            Response.Redirect("tomainvEstados.aspx");
        }

        protected void btnTomaInvReporteT_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "TomaInventarioReporteG");
            if ((OpcionEnti.tbValor == 1))
            {
                //VentasGCListarPL();

                //ExcelLibrary.DataSetHelper.CreateWorkbook(AppDomain.CurrentDomain.BaseDirectory + "\\ResporteSicoNet.xls", ventasgcExcelNego.VentasGeneralesDetalleConsultarDS(txtFecha1.Text , txtFecha2.Text , ddlList.Text ));
                //Response.Redirect("/ResporteSicoNet.xls");

                TInventarioGExportarExcel();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }
    }
}