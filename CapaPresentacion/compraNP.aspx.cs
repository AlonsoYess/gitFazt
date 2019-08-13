using System;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class compraNP : System.Web.UI.Page

    {
        CompraNPNegocio CompraNPNego = new CompraNPNegocio();
        CompraNPEntidad CompraNPEnti = new CompraNPEntidad();


        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnCompra_Click(object sender, EventArgs e)
        {
            ListarDatos();
            //txtCotizacion.Focus();
        }

        private void ListarDatos()
        {
            try
            {
                grdComprasNotaP.DataSource = CompraNPNego.CompraNPListar( txtEmpresa.SelectedValue, txtNotaPedido.Text , txtOrdenCompra.Text);
                grdComprasNotaP.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }
    }
}