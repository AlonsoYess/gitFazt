using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class consultastock : System.Web.UI.Page
    {
        ProductoStockNegocio ProductoStockNego  = new ProductoStockNegocio();
        ProductoStockEntidad ProductoStockEnti  = new ProductoStockEntidad();

        SAPStockxProductoNegocio VentasGCNego   = new SAPStockxProductoNegocio();
        SAPStockxProductoEntidad VentasGCEnti   = new SAPStockxProductoEntidad();

        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        private void ListarDatos()
        {
            try
            {
                GridVStockDatos.DataSource = ProductoStockNego.ProductoStockListar(txtValor.Text);
                GridVStockDatos.DataBind();

                GridProductoyVentas.DataSource = VentasGCNego.VentasSTOCKSAPConsultar(txtValor.Text);
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
            else
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cstock");
                if ((OpcionEnti.tbValor == 0))
                {

                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - cstock');window.location.href ='menup.aspx';</script>");
                }

                if (!IsPostBack)
                {
                    ListarDatos();
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridVStockDatos_RowDataBound(object sender, GridViewRowEventArgs e)
        { /*
            e.Row.Cells[7].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[8].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[9].HorizontalAlign = HorizontalAlign.Right;
            */
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarDatos();
        }

        protected void btnStockBuscar_Click1(object sender, EventArgs e)
        {

        }

        protected void GridVStockDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}