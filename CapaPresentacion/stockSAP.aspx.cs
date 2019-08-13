using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class stockSAP : System.Web.UI.Page
    {
        SAPStockxProductoNegocio VentasGCNego = new SAPStockxProductoNegocio();
        SAPStockxProductoEntidad VentasGCEnti = new SAPStockxProductoEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma =0 ;
     

        private void VentasGCListarPL()
        {
            try
            {
                GridProductoyVentas.DataSource = VentasGCNego.VentasSTOCKSAPConsultar( TextBox1.Text );
                GridProductoyVentas.DataBind();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
                VentasGCListarPL();
        }



    }
}