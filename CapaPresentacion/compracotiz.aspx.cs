using System;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class compracotiz : System.Web.UI.Page

    {
        CompraNegocio CompraNego = new CompraNegocio();
        CompraEntidad CompraEnti = new CompraEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "compracotiza");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - compracotiza');window.location.href ='menup.aspx';</script>");
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
                grdComprasCotiz.DataSource = CompraNego.CompraCotizListar(txtCotizacion.Text , txtOrdenCompra.Text);
                grdComprasCotiz.DataBind();
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