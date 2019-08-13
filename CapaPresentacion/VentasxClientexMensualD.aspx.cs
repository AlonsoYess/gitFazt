using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class VentasxClientexMensualD : System.Web.UI.Page
    {
        VentasxClientexMensualDetalleNegocio VentasxClientexMensualDetalleNego = new VentasxClientexMensualDetalleNegocio();
        VentasxClientexMensualDetalleEntidad VentasxClientexMensualDetalleEnti = new VentasxClientexMensualDetalleEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        DateTime fechaIn;
        DateTime fechaFi;
        string ven, cli, empr;


        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = VentasxClientexMensualDetalleNego.VxClienteDetalleDT(fechaIn,fechaFi,ven,cli,empr );
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fechaIn = (Convert.ToDateTime(Request.QueryString["datos1"]));
                fechaFi = (Convert.ToDateTime(Request.QueryString["datos2"]));
                ven = (Request.QueryString["datos3"]);
                cli = (Request.QueryString["datos4"]);
                empr = (Request.QueryString["datos5"]);
                VentasGCListarPL();
            }


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }


        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
           /* //OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {

                VentasGCListarPL();

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");
            }
                */
        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {/*
            e.Row.Cells[04].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[05].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[06].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[07].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[08].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[09].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[10].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[11].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[12].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[13].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[14].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[15].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[16].HorizontalAlign = HorizontalAlign.Right;

            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            /*if (e.Row.RowType == DataControlRowType.DataRow)
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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtVendedor.Text) + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                   // Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


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

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "999")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtVendedor.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

        }

        protected void btnVentaPBuscar_Click1(object sender, EventArgs e)
        {
            VentasGCListarPL();
        }
    }
}