using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class clientedoc : System.Web.UI.Page
    {
        /*ClienteDocNegocio ClienteDocNego = new ClienteDocNegocio();
        ClienteDocEntidad ClienteDocEnti = new ClienteDocEntidad();*/
        ClienteDetalleDetNegocio _ClienteDetalleDetNegocio = new ClienteDetalleDetNegocio();
        ClienteDetalleDetEntidad _ClienteDetalleDetEntidad = new ClienteDetalleDetEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string v1 = "";
        string v2 = "";
        string v3 = "";
        string v4 = "";
        string v5 = "";
        string razon = "";
        string cliente = "";
          private void ClienteDocListarPL()
        {
            try
            {
                GridClienteDoc.DataSource = _ClienteDetalleDetNegocio.ClienteDetalleConsultarDET(v1, v2, v3, v4,v5);
                GridClienteDoc.DataBind();
            }
            catch (Exception)
            {

            }
        }

        private void asisnarValores()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            v1 = Request.QueryString["datos1"];
            v2 = Request.QueryString["datos2"];
            v3 = Request.QueryString["datos3"];
            v4 = Request.QueryString["datos4"];
            v5 = Request.QueryString["datos5"];
            razon = Request.QueryString["datos6"];
            cliente = Request.QueryString["datos7"];

            Label1.Text = cliente;
            Label2.Text = razon;

            ClienteDocListarPL();


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            ClienteDocListarPL();
        }

        
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridPuntoyVendedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            /*e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                suma = suma + Convert.ToDouble(e.Row.Cells[4].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[3].Text = "Total :";
                    e.Row.Cells[4].Text = suma.ToString("N");
                    e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;             
                }

            }*/
        }

        protected void GridPuntoyVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

         
           
        }


    }
}