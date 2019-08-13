
using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class clientedetalle : System.Web.UI.Page
    {
        ClienteDetalleNegocio ClienteDetalleNego = new ClienteDetalleNegocio();
        ClienteDetalleEntidad ClienteDetalleEnti = new ClienteDetalleEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0;
        string codigo = string.Empty;
        string cliente = string.Empty;
        string razon = string.Empty;
        string FechaInicio = DateTime.Now.ToString("01/01/2000");
        string FechaFin = DateTime.Now.ToShortDateString();
        string codigoEmpresa = string.Empty;
        private void ClienteDetalleListarVentasSaP()
        {
            try
            {
                GridPuntoyVendedor.DataSource = ClienteDetalleNego.ClienteDetalleConsultarCAB(Convert.ToDateTime(FechaInicio), Convert.ToDateTime(FechaFin), cliente, codigoEmpresa);
                GridPuntoyVendedor.DataBind();
            }
            catch (Exception)
            {

            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            codigo = Request.QueryString["datos1"];
            cliente = Request.QueryString["datos2"];
            razon   = Request.QueryString["datos3"];

            Label1.Text = cliente;
            Label2.Text = razon;
            asignaValores();
            ClienteDetalleListarVentasSaP();


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
        }

        private void asignaValores()
        {
            if (codigo == "PROMATISA")
            {
                codigoEmpresa = "STARSOFT";
            }
            else if (codigo == "ACSA")
            {
                if (cliente.Substring(0, 1) == "C")
                {
                    codigoEmpresa = "SAP";
                }
                else
                {
                    codigoEmpresa = "LISA";
                }
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
         //   VentasGCPVListarPL();
        }

        
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }

        protected void GridPuntoyVendedor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[8].HorizontalAlign = HorizontalAlign.Right;
            /*
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

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tclientedoc");
            if ((OpcionEnti.tbValor == 1))
            {

                if (codigoEmpresa == "SAP")
                {
                    Response.Redirect(
                        "clientedoc.aspx?datos1=" +
                        "0" +
                        "&datos2=" + cliente +
                        "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[0].Text +
                        "&datos4=" + codigoEmpresa +
                        "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[8].Text +
                        "&datos6=" + razon +
                        "&datos7=" + cliente);
                }
                else if (codigoEmpresa == "LISA")
                {
                    Response.Redirect(
                       "clientedoc.aspx?datos1=" +
                       this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[8].Text +
                       "&datos2=" +"0" +
                       "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[7].Text +
                       "&datos4=" + codigoEmpresa +
                       "&datos5=" + "0" +
                       "&datos6=" + razon +
                       "&datos7=" + cliente);
                }
                else if (codigoEmpresa == "STARSOFT")
                {
                    Response.Redirect(
                        "clientedoc.aspx?datos1=" +
                        this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[8].Text +
                        "&datos2=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[7].Text.Substring(0,3) +
                        "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[7].Text.Substring(3,7) +
                        "&datos4=" + codigoEmpresa +
                        "&datos5=" + "0"+
                        "&datos6=" + razon +
                        "&datos7=" + cliente);
                }
                else
                {
                   /* Response.Redirect(
                        "clientedoc.aspx?datos1=" +
                        this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[8].Text +
                        "&datos2=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[3].Text +
                        "&datos3=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[4].Text +
                        "&datos4=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[6].Text +
                        "&datos5=" + this.GridPuntoyVendedor.Rows[GridPuntoyVendedor.SelectedIndex].Cells[7].Text);*/

                }
                    

            }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tclientedoc');</script>");
                    /*Response.Redirect("sico.aspx");*/
                }
           

         
        }


    }
}