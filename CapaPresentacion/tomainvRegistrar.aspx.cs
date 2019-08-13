using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class tomainvRegistrar : System.Web.UI.Page
    {


        TomaInventariosAutorizarNegocio TEstadoActualizarNego = new TomaInventariosAutorizarNegocio();
        TomaInventariosRegistroConteoNegocio TomaInventariosRegistroConteoNego = new TomaInventariosRegistroConteoNegocio();

        ConsultasNegocio ConsultasNego = new ConsultasNegocio();
        invConteoEntidad ConsultasEnti = new invConteoEntidad();

        InventarioANegocio InventarioANego = new InventarioANegocio();
        InventarioAEntidad InventarioAEnti = new InventarioAEntidad();

        ConsultasDNegocio ConsultasDNego = new ConsultasDNegocio();
        ConsultasDEntidad ConsultasDEnti = new ConsultasDEntidad();


        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        //Double suma = 0 ;
        int NroInv;
        string EstInv = "";
        int error;

        private void InventarioAPL()
        {
            try
            {
                ddlList.DataSource = InventarioANego.InventarioADT(ddlList0.Text);
                ddlList.DataTextField = "invdescripcion";
                ddlList.DataValueField = "invcodigo";
                ddlList.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InventarioAPL();
            /*NroInv = Convert.ToInt16(Request.QueryString["datos1"]);
            EstInv = Request.QueryString["datos1"];*/

            /*lblInventario.Text = Request.QueryString["datos1"];
            lblEInventario.Text = Request.QueryString["datos2"];*/

            //VentasGCListarPL();
            if (!Page.IsPostBack)
            {
                //txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");

            }


            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }


        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            /*OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), ddlList.Text);
            if ((OpcionEnti.tbValor == 1))
            {

                VentasGCListarPL();

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");
            }*/

        }


        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            /* e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
             if (e.Row.RowType == DataControlRowType.DataRow)
             {

                 suma = suma + Convert.ToDouble(e.Row.Cells[2].Text);
             }
             else
             {
                 if (e.Row.RowType == DataControlRowType.Footer)
                 {
                     e.Row.Cells[1].Text = "Total :";
                     e.Row.Cells[2].Text = suma.ToString("N");
                     e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;


                 }

             }*/

        }

        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text == "999")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {
                    //Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                    // Response.Redirect("sico.aspx");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {/*
            TEstadoActualizarNego.TomaInventariosActualizar (
                Convert.ToInt16 (lblInventario.Text) ,
                Session["rusiausuario"].ToString(),
                DateTime.Now,
                DateTime.Now.ToLocalTime(),
                lblEInventario.Text ,
                "Autorizado"
                );
            Response.Redirect("tomainvEstados.aspx");*/
         //InventarioAPL();
         //(Numero, Usuario, Conteo, Codigo, Cantidad, Fecha, Hora, Ubicacion);


            if (ConsultasNego.invConteo(
                    Convert.ToInt16(ddlList.SelectedValue),
                    Session["rusiausuario"].ToString(),
                    ddlList0.Text,
                    txtCodigo.Text,
                    Convert.ToDecimal(txtCantidad.Text),
                    DateTime.Now,
                    DateTime.Now.ToLocalTime(),
                    Convert.ToInt16(ddlList1.Text)).tbcontador == 1)
            {

                Response.Write("<script language=javascript>alert('Ya existe Registro en la ubicación / Actualize o Cambie de Ubicación');</script>");
                btnTomaInvActualizarC.Visible = true;

            }
            else
            {
                TomaInventariosRegistroConteoNego.TomaInventariosRegistrarConteo(
                    Convert.ToInt16(ddlList.SelectedValue),
                    Session["rusiausuario"].ToString(),
                    ddlList0.Text,
                    txtCodigo.Text,
                    Convert.ToDecimal(txtCantidad.Text),
                    DateTime.Now,
                    DateTime.Now.ToLocalTime(),
                    Convert.ToInt16(ddlList1.Text)
                    );
                txtCodigo.Text = "";
                lblDes.Text = "";
                txtCantidad.Text = "";


            }



        }

        protected void ddlList0_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventarioAPL();
        }

        protected void txtCodigo_Unload(object sender, EventArgs e)
        {

        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblDes.Text = ConsultasDNego.ProductoDatos(txtCodigo.Text).tbadescri.ToString();
        }

        protected void btnTomaInvActualizarC_Click(object sender, EventArgs e)
        {
            TomaInventariosRegistroConteoNego.TomaInventariosRegistrarConteoUpdate(
                Convert.ToInt16(ddlList.SelectedValue),
                Session["rusiausuario"].ToString(),
                ddlList0.Text,
                txtCodigo.Text,
                Convert.ToDecimal(txtCantidad.Text),
                DateTime.Now,
                DateTime.Now.ToLocalTime(),
                Convert.ToInt16(ddlList1.Text)
                );
            txtCodigo.Text = "";
            lblDes.Text = "";
            txtCantidad.Text = "";
            btnTomaInvActualizarC.Visible = false;

        }
    }
}