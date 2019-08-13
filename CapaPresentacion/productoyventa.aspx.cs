using System;
using CapaNegocio;
using CapaEntidad;




namespace CapaPresentacion
{
    public partial class productoyventa : System.Web.UI.Page
    {
        ProductoyVentasNegocio ProductoyVentasNego = new ProductoyVentasNegocio();
        ProductoyVentasEntidad ProductoyVentasEnti = new ProductoyVentasEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        string codigoArticulo = string.Empty;
        string ruc = string.Empty;
        string Empresa = string.Empty;

        private void ProductoyVentaListar()
        {
            try
            {
                asignarValores();
                GridProductoyVentas.DataSource = ProductoyVentasNego.ProductoyVentasListar(txtCodigo.Text , ruc, ddEmpresa.Text );
                GridProductoyVentas.DataBind();
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

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "productoyventa");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Producto y sus Ventas - productoyventa');window.location.href ='menup.aspx';</script>");
            }
        }

        private void asignarValores()
        {
            if (txtRuc.Text == "")
            {
                ruc = "0";
            }
            else
            {
                ruc = txtRuc.Text;
            }

            
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            ProductoyVentaListar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }
    }
}