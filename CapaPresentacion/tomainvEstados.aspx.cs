using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class tomainvEstados : System.Web.UI.Page
    {
        TEstadoNegocio TEstadoNego = new TEstadoNegocio();
        TEstadoEntidad TEstadoEnti = new TEstadoEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;

        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = TEstadoNego.TomaIEstadosDT();
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            VentasGCListarPL();
            if (!Page.IsPostBack)
            {
                //txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
    
            }


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }


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
            
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tomainvEDetalle");
                if ((OpcionEnti.tbValor == 1))
                {
                    Response.Redirect("tomainvEDetalle.aspx?datos1=" + this.GridProductoyVentas.Rows[this.GridProductoyVentas.SelectedIndex].Cells[0].Text + "&datos2=" + this.GridProductoyVentas.Rows[this.GridProductoyVentas.SelectedIndex].Cells[8].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tomainvEDetalle');</script>");
                    // Response.Redirect("sico.aspx");
                }
            

        }

        protected void GridProductoyVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           

        }
    }
}