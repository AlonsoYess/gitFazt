using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class ventasgc : System.Web.UI.Page
    {
        VentasGCNegocio VentasGCNego = new VentasGCNegocio();
        VentasxClientexMensualEntidad VentasGCEnti = new VentasxClientexMensualEntidad();

        SAPVentasGCNegocio SAPVentasGCNego = new SAPVentasGCNegocio();
        SAPVentasGCEntidad SAPVentasGCEnti = new SAPVentasGCEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        Double sumaBO = 0;


        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = VentasGCNego.VentasGCListarCDatos(Convert.ToDateTime ( txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text);
                GridProductoyVentas.DataBind();

                suma = 0;
                GridVentasGCSAP.DataSource = SAPVentasGCNego.VentasGCSAPConsultar(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), ddlList.Text);
                GridVentasGCSAP.DataBind();
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

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGC");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGC');window.location.href ='menup.aspx';</script>");
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

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {

                VentasGCListarPL();

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
                
        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                
                suma = suma + Convert.ToDouble(e.Row.Cells[2].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer) 
                {
                    e.Row.Cells[1].Text = "TOTAL CORP. PROMATISA S/.  :";
                    e.Row.Cells[2].Text = suma.ToString("N");
                    e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;                   
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
                    Response.Redirect("ventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);
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

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "999")
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

        protected void GridVentasGCSAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text == "PDV")
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("SAPventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                }
            }
            if (this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text == "RETAIL")
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("SAPventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                }
            }
            if (this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text == "CORPORATIVOS")
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("SAPventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                }
            }
            if (this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text == "MAYORISTAS")
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("SAPventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                }
            }
            if (this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text == "PROYECTOS-INGENIERIA")
            {
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("SAPventasgcpv.aspx?datos1=" + Convert.ToDateTime(txtFecha1.Text) + "&datos2=" + Convert.ToDateTime(txtFecha2.Text) + "&datos3=" + this.GridVentasGCSAP.Rows[GridVentasGCSAP.SelectedIndex].Cells[1].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                }
            }
        }

        protected void GridVentasGCSAP_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                sumaBO = sumaBO + Convert.ToDouble(e.Row.Cells[2].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[1].Text = "TOTAL ACSA CORP S/. :";
                    e.Row.Cells[2].Text = sumaBO.ToString("N");
                    e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
                }

            }
        }
    }
}