using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class tomainvmenu : System.Web.UI.Page
    {
        AlmacenNegocio AlmacenNego = new AlmacenNegocio();
        AlmacenEntidad AlmacenEnti = new AlmacenEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
     

        private void AlmacenLlenarDatos()
        {
            try
            {
         
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {




                AlmacenLlenarDatos();
            }

                
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

           // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {

            //Label1.Text = ddlList.Text ;
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "GTInventario");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("tomainv.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a - GTInventario');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void btnVentaPBuscar0_Click(object sender, EventArgs e)
        {
            //Label1.Text = ddlList.Text ;
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "CTInventario");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("tomainvmenu.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a - CTInventario');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void btnVentaPBuscar1_Click(object sender, EventArgs e)
        {
            //Label1.Text = ddlList.Text ;
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "RTInventario");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("tomainvmenu.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a - RTInventario');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void btnVentaPBuscar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("tomainvEstados.aspx"); 
        }

        protected void btnVentaPBuscar0_Click1(object sender, EventArgs e)
        {
            
                  OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "RegTInventario");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("tomainvRegistrar.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a - RegTInventario');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void btnVentaPBuscar1_Click1(object sender, EventArgs e)
        {

        }
    }
}