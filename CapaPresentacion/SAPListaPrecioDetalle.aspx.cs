using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SAPListaPrecioDetalle : System.Web.UI.Page
    {
        string codigo, nombreLista;
        SAPListaPrecioStockNegocio SAPListaPrecioStockNego = new SAPListaPrecioStockNegocio();
        SAPListaPrecioStockEntidad SAPListaPrecioStockEnti = new SAPListaPrecioStockEntidad();


        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ventaslistaprecio");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Lista de Precios - ventaslistaprecio');window.location.href ='menup.aspx';</script>");
            }
            codigo = Request.QueryString["datos1"];
            nombreLista = Request.QueryString["datos2"];
            Label1.Text = nombreLista;
            Listar();


        }

        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridProductoyVentas_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridProductoyVentas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridProductoyVentas.PageIndex = e.NewPageIndex;
            Listar();
        }

       

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {
            string TextToSearch = TextBox1.Text;
            if (TextToSearch != "")
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = SAPListaPrecioStockNego.SapListaPrecioDetalleDT(codigo);
                //bs.DataSource = grdListado.Page;
                bs.Filter = $"[ItemCode] LIKE '%{TextToSearch}%'";
                GridProductoyVentas.DataSource = bs;
                GridProductoyVentas.DataBind();

            }
            else
            {
                GridProductoyVentas.DataSource = SAPListaPrecioStockNego.SapListaPrecioDetalleDT(codigo);
                GridProductoyVentas.DataBind();
            }
        }

        private void Listar()
        {
            try
            {
                GridProductoyVentas.DataSource = SAPListaPrecioStockNego.SapListaPrecioDetalleDT(codigo);
                GridProductoyVentas.DataBind();
            }
            catch
            {

            }
            
        }

    }
}