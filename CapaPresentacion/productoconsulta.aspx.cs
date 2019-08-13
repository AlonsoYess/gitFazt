using System;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class productoconsulta : System.Web.UI.Page

    {
        ProductoNegocio ProductoNego = new ProductoNegocio();
        ProductoEntidad ProductoEnti = new ProductoEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        String Datos;


        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            else
            {
                if (!IsPostBack)
                {
                   // ListarDatos();
                }
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
             ListarDatos();
            //txtCotizacion.Focus();
        }

        private void ListarDatos()
        {
            try
            {
                grdClientes.DataSource = ProductoNego.ProductoConsultar(txtDatoHijo.Text);
                grdClientes.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void grdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tclientedet");
            if ((OpcionEnti.tbValor == 1))
            {
                //Response.Redirect("clientedetalle.aspx?datos1=" + this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[1].Text + "&datos2=" + this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[3].Text);

                /*Response.Redirect("ventasgcpvdetalle.aspx?datos1=" + Label1.Text.ToString() 
                    + "&datos2=" + Label2.Text.ToString()
                    + "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text 
                    + "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[2].Text 
                    + "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text);*/
                //txtDato.Text = this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[1].Text;
                //lblCod.Text = this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[1].Text;
                //lblDes.Text = this.grdClientes.Rows[grdClientes.SelectedIndex].Cells[3].Text;

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tclientedet');</script>");
                Response.Redirect("sico.aspx");
            }
        }
    }
}