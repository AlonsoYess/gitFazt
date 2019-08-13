using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class ventasgcpvdetalle : System.Web.UI.Page
    {
        VentasGCPVDetalleNegocio VentasGCPVDetalleNego = new VentasGCPVDetalleNegocio();
        VentasGCPVDetalleEntidad VentasGCPVDetalleEnti = new VentasGCPVDetalleEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string Punto = "";
        string Vendedor = "";
        string VendedorDes = "";
        DateTime  FechaI ;
        DateTime  FechaF ;
        string codigoEmpresa = "STARSOFT";
        private void VentasGCPVDetalleListarPL()
        {
            try
            {
                GridPuntoyVendedor.DataSource = VentasGCPVDetalleNego.VentasGCPVDetalleListarCDatos(Punto, Vendedor, FechaI, FechaF);
                GridPuntoyVendedor.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaI      = Convert.ToDateTime(Request.QueryString["datos1"]);
            FechaF      = Convert.ToDateTime(Request.QueryString["datos2"]);
            Punto       =   Request.QueryString["datos3"];
            Vendedor    =   Request.QueryString["datos4"];
            VendedorDes =   Request.QueryString["datos5"];


            Label1.Text     = Request.QueryString["datos1"];
            Label2.Text     = Request.QueryString["datos2"];
            lblPunto.Text   = Request.QueryString["datos3"];
            lblVen.Text     = Request.QueryString["datos4"];
            lblVenD.Text    = Request.QueryString["datos5"];

            VentasGCPVDetalleListarPL();


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            VentasGCPVDetalleListarPL();
        }

        
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridPuntoyVendedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[10].HorizontalAlign = HorizontalAlign.Right;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                suma = suma + Convert.ToDouble(e.Row.Cells[10].Text);
            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[9].Text = "Total :";
                    e.Row.Cells[10].Text = suma.ToString("N");
                    e.Row.Cells[10].HorizontalAlign = HorizontalAlign.Right;


                }

            }
        }

        protected void GridPuntoyVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tclientedoc");
            if ((OpcionEnti.tbValor == 1))
            {
                string SerieDoc = this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[9].Text;
                SerieDoc =  SerieDoc.Substring(0, SerieDoc.Length - 7);
                SerieDoc = SerieDoc.PadLeft(3, '0');
                string NroDoc = this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[9].Text;
                Response.Redirect(
                         "clientedoc.aspx?datos1=" +
                         this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[8].Text +
                         "&datos2=" + SerieDoc +
                         "&datos3=" + NroDoc.Substring(NroDoc.Length  -  7) +
                         "&datos4=" + codigoEmpresa +
                         "&datos5=" + "0" +
                         "&datos6=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[5].Text +
                         "&datos7=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[6].Text);
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tclientedoc');</script>");
                /*Response.Redirect("sico.aspx");*/
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }
    }
}