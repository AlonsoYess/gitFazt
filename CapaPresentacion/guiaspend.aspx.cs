using System;
using System.Data;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using OfficeOpenXml;
using System.IO;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class guiaspend : System.Web.UI.Page
    {
        GuiaRemisionPendienteNegocio GuiaRemisionPendienteNego = new GuiaRemisionPendienteNegocio();
        GuiaRemisionPendienteEntidad GuiaRemisionPendienteEnti = new GuiaRemisionPendienteEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string serie = string.Empty;
        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = GuiaRemisionPendienteNego.GuiaRemisionPendienteListarDS(Convert.ToDateTime(txtFecha1.Text),Convert.ToDateTime(txtFecha2.Text), ddSerie.SelectedValue, ddlEst.SelectedValue,ddEmpresa.Text );
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {

            }
        }

        private void cargarSerie()
        {

             
            

        }

        private void GuiasPendExportarExcel()
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

            ew1.Cells["A1"].LoadFromDataTable(GuiaRemisionPendienteNego.GuiaRemisionPendienteListarDT(Convert.ToDateTime(txtFecha1.Text),Convert.ToDateTime(txtFecha2.Text), ddSerie.SelectedValue, ddlEst.SelectedValue, ddEmpresa.Text), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "guiaspend");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - guiaspend');window.location.href ='menup.aspx';</script>");
            }
            if (!IsPostBack)
            {
                cargarACSA();
                txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
           


        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "guiaspend");
            if ((OpcionEnti.tbValor == 1))
            {
                VentasGCListarPL();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta - guiaspend ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }

        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           e.Row.Cells[12].HorizontalAlign = HorizontalAlign.Right;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                suma = suma + Convert.ToDouble(e.Row.Cells[12].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[11].Text = "Total :";
                    e.Row.Cells[12].Text = suma.ToString("N");
                    e.Row.Cells[12].HorizontalAlign = HorizontalAlign.Right;
                    

                }
                    
            }
                     
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
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "guiaspend");
            if ((OpcionEnti.tbValor == 1))
            {
                GuiasPendExportarExcel();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta - guiaspend ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

      

        private void cargarSerieSAP()
        {
            List<string> data = new List<string>();
            
        }

        

        private void cargarPromatisa()
        {
            DataTable dt;
            dt = new DataTable("Tabla");

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "000";
            dr["Descripcion"] = "000";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "001";
            dr["Descripcion"] = "001";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "002";
            dr["Descripcion"] = "002";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "003";
            dr["Descripcion"] = "003";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "004";
            dr["Descripcion"] = "004";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "005";
            dr["Descripcion"] = "005";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "006";
            dr["Descripcion"] = "006";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "007";
            dr["Descripcion"] = "007";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "008";
            dr["Descripcion"] = "008";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "009";
            dr["Descripcion"] = "009";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "010";
            dr["Descripcion"] = "010";
            dt.Rows.Add(dr);

            ddSerie.DataSource = dt;
            ddSerie.DataValueField = "Codigo";
            ddSerie.DataTextField = "Descripcion";
            ddSerie.DataBind();
        }

        private void cargarACSA() {
            DataTable dt;
            dt = new DataTable("Tabla");

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "12";
            dr["Descripcion"] = "GR02-19";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "13";
            dr["Descripcion"] = "GR03-19";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "11";
            dr["Descripcion"] = "GR04-19";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "60";
            dr["Descripcion"] = "GRIN-19";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "000";
            dr["Descripcion"] = "000";
            dt.Rows.Add(dr);


            ddSerie.DataSource = dt;
            ddSerie.DataValueField = "Codigo";
            ddSerie.DataTextField = "Descripcion";
            ddSerie.DataBind();
        }

        protected void ddEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddEmpresa.Text == "PROMATISA")
            {
                cargarPromatisa();
            }else
            {
                cargarACSA();
            }
        }
    }
}