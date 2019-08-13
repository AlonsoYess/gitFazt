using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class clientegrupo : System.Web.UI.Page
    {
        ClienteGrupoNegocio ClienteGrupoNego = new ClienteGrupoNegocio();
        ClienteGrupoEntidad ClienteGrupoEnti = new ClienteGrupoEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string Punto = "";
        string FechaI = "";
        string FechaF = "";

          private void VentasGCPVListarPL()
        {
            try
            {
                GridPuntoyVendedor.DataSource = ClienteGrupoNego.ClienteGrupoConsultar(Punto, FechaI, FechaF);
                GridPuntoyVendedor.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaI = Request.QueryString["datos1"];
            FechaF = Request.QueryString["datos2"];
            Punto  = Request.QueryString["datos3"];

            Label1.Text = Request.QueryString["datos1"];
            Label2.Text = Request.QueryString["datos2"];

            VentasGCPVListarPL();


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            VentasGCPVListarPL();
        }

        
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridPuntoyVendedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                suma = suma + Convert.ToDouble(e.Row.Cells[6].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[5].Text = "Total :";
                    e.Row.Cells[6].Text = suma.ToString("N");
                    e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;             
                }

            }
        }

        protected void GridPuntoyVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "100")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }

            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "200")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "mvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - mvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }

            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "300")
            {
               
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "rvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - rvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "400")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "950")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }

            if (this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text == "998")
            {
                
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() + "&datos2=" + Label2.Text.ToString() + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    /* Response.Redirect("sico.aspx");*/
                }
            }
        }


    }
}