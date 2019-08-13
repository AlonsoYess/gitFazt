using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class SAPventasgcpv : System.Web.UI.Page
    {
        SAPVentasGCPuntoNegocio SAPVentasGCPuntoNego = new SAPVentasGCPuntoNegocio();
        SAPVentasGCPuntoDetalleEntidad SAPVentasGCPuntoEnti = new SAPVentasGCPuntoDetalleEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string Punto = "";
        DateTime  FechaI ;
        DateTime FechaF ;

          private void VentasGCPVListarPL()
        {
            try
            {
                GridPuntoyVendedor.DataSource = SAPVentasGCPuntoNego.VentasGCPuntoSAPConsultar( FechaI, FechaF, Punto);
                GridPuntoyVendedor.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaI = Convert.ToDateTime( Request.QueryString["datos1"]);
            FechaF = Convert.ToDateTime( Request.QueryString["datos2"]);
            Punto  = Request.QueryString["datos3"];

            Label1.Text = Request.QueryString["datos1"];
            Label2.Text = Request.QueryString["datos2"];

            VentasGCPVListarPL();


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
        }

       
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridPuntoyVendedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                suma = suma + Convert.ToDouble(e.Row.Cells[4].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[3].Text = "Total x Canal :";
                    e.Row.Cells[4].Text = suma.ToString("N");
                    e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;             
                }

            }
        }

        protected void GridPuntoyVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text == "PDV")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("SAPventasgcpuntodetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text == "MAYORISTAS")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("SAPventasgcpuntodetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text == "CORPORATIVOS")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("SAPventasgcpuntodetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text == "RETAIL")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("SAPventasgcpuntodetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text == "PROYECTOS-INGENIERIA")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("SAPventasgcpuntodetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[1].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }

        }


    }
}