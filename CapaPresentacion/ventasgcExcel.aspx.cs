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
    public partial class ventasgcExcel : System.Web.UI.Page
    {
        VentasGeneralesDetalleNegocio ventasgcExcelNego = new VentasGeneralesDetalleNegocio();
        VentasGeneralesDetalleEntidad ventasgcExcelEnti = new VentasGeneralesDetalleEntidad();

        VentasGeneralesDetalleEENegocio ventasgcExcelEENego = new VentasGeneralesDetalleEENegocio();
        VentasGeneralesDetalleEEEntidad ventasgcExcelEEEnti = new VentasGeneralesDetalleEEEntidad();

        SAPVentasGeneralesDetalleNegocio SAPventasgcExcelNego = new SAPVentasGeneralesDetalleNegocio();
        SAPVentasGeneralesDetalleEntidad SAPventasgcExcelEnti = new SAPVentasGeneralesDetalleEntidad();

        SAPVentasGeneralesDetalleEENegocio SAPventasgcExcelEENego = new SAPVentasGeneralesDetalleEENegocio();
        SAPVentasGeneralesDetalleEEEntidad SAPventasgcExcelEEEnti = new SAPVentasGeneralesDetalleEEEntidad();


        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;

        private void VentasExportarExcel()
        {
            // Creamos el archivo
                String Nombre ="StarSoftLISA"
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

            ew1.Cells["A1"].LoadFromDataTable(ventasgcExcelNego.VentasGeneralesDetalleConsultarDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre );

        }

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

            ew1.Cells["A1"].LoadFromDataTable(SAPventasgcExcelNego.VentasGeneralesDetalladaSAPDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }

        private void VentasExportarEEExcel()
        {
            // Creamos el archivo
            String Nombre = "StarSoftLISAEE"
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

            ew1.Cells["A1"].LoadFromDataTable(ventasgcExcelEENego.VentasGeneralesDetalleConsultarEEDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }

        private void SAPVentasExportarEEExcel()
        {
            // Creamos el archivo
            String Nombre = "SAPEE"
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

            ew1.Cells["A1"].LoadFromDataTable(SAPventasgcExcelEENego.VentasGeneralesDetalladaSAPEEDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = ventasgcExcelNego.VentasGeneralesDetalleConsultarDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text);
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {

            }
        }

        private void ValidaCampo()
        {
            if(txtFecha1.Text == "")
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGCExcel");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGCExcel');window.location.href ='menup.aspx';</script>");
            }

            if (!Page.IsPostBack)
            {
                txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = Convert.ToDateTime(txtFecha1.Text);

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFecha1.Text = FechaI.ToString("yyyy-MM-dd");
            }
            // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {
                //VentasGCListarPL();

                //ExcelLibrary.DataSetHelper.CreateWorkbook(AppDomain.CurrentDomain.BaseDirectory + "\\ResporteSicoNet.xls", ventasgcExcelNego.VentasGeneralesDetalleConsultarDS(txtFecha1.Text , txtFecha2.Text , ddlList.Text ));
                //Response.Redirect("/ResporteSicoNet.xls");

                VentasExportarExcel();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
           
        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            /*e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
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
             if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "100")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "200")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "mvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - mvendedordet');</script>");
                 
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "300")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "rvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - rvendedordet');</script>");
                
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "400")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "401")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "950")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "998")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }
        }

        protected void btnVentaPBuscar0_Click(object sender, EventArgs e)
        {
            SAPVentasExportarExcel();
        }

        protected void btnVentaPBuscar1_Click(object sender, EventArgs e)
        {
            VentasExportarEEExcel();
        }

        protected void btnVentaPBuscar2_Click(object sender, EventArgs e)
        {
            SAPVentasExportarEEExcel();
        }
    }
}