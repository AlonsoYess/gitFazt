using System;
using CapaNegocio;
using CapaEntidad;




namespace CapaPresentacion
{
    public partial class seguimientosa : System.Web.UI.Page
    {
        LogisticaSegSANegocio LogisticaSegSANego = new LogisticaSegSANegocio();
        LogisticaSegSAEntidad LogisticaSegSAEnti = new LogisticaSegSAEntidad();

        private void LogisticaSAListar()
        {
            try
            {
                GridSeguimientoSA.DataSource = LogisticaSegSANego.LogisticaSegSAListar(Convert.ToString(txtFecha1.Text), (txtFecha2.Text), txtAlmacen.SelectedValue , txtEmpresa.SelectedValue);
                GridSeguimientoSA.DataBind();
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

            //txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        protected void btnStockBuscar_Click(object sender, EventArgs e)
        {
            LogisticaSAListar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }
    }
}