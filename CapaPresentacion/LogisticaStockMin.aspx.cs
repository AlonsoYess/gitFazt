using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;
using OfficeOpenXml;

namespace CapaPresentacion
{
    public partial class LogisticaStockMin : System.Web.UI.Page
    {
        LogisticaStockMinNegocio LogisticaStockMinNego = new LogisticaStockMinNegocio();
        LogisticaStockMinEntidad LogisticaStockMinEnti = new LogisticaStockMinEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();


        private void LogisticaStockMinExportarExcel()
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

            ew1.Cells["A1"].LoadFromDataTable(LogisticaStockMinNego.LogisticaStockMinListarCDatos(txtFecha1.Text, txtFecha2.Text, ddlList.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        private void LogisticaStockMinListarPL()
        {
            try
            {
                GLogisticaStockMin.DataSource = LogisticaStockMinNego.LogisticaStockMinListarCDatos(txtFecha1.Text, txtFecha2.Text, ddlList.Text);
                GLogisticaStockMin.DataBind();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "stockminimo");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - stockminimo');window.location.href ='menup.aspx';</script>");
            }

           // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {
                LogisticaStockMinListarPL();
                //btnExcel.Visible = true;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta - total ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
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
        {/*
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
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {
                LogisticaStockMinExportarExcel();
                //btnExcel.Visible = true;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta - total ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
            //ExportToExcel("StockMinimo" + DateTime.Now + ".xls", GLogisticaStockMin);
        }
        private void ExportToExcel(string nameReport, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet";
            response.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            for (int i = 0; i < wControl.Rows.Count; i++)
            {
                wControl.Rows[i].Attributes.Add("class", "textmode");
            }
            //wControl.RenderControl(htw);
            string style = @"<style> .textmode { } </style>";

            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "StockMinimo" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            GLogisticaStockMin.GridLines = GridLines.Both;
            GLogisticaStockMin.HeaderStyle.Font.Bold = true;
            GLogisticaStockMin.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();

        }

        public void ExportarDataGridViewExcel(GridView grd)
        {
            //Exporto a Excel
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            System.Web.UI.HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pagina = new Page();
            HtmlForm forma = new HtmlForm();
            pagina.Controls.Add(forma);
            forma.Controls.Add(grd);
            pagina.RenderControl(htw);
            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("Content - Disposition", "attachment; filename =" + "StockMinimo" + DateTime.Now + ".xlsx");
            Response.Charset = "UTF - 8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }



    }
}