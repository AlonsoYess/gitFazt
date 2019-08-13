using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;



namespace CapaPresentacion
{
    public partial class tomainv : System.Web.UI.Page
    {
        TomaInventariosNegocio TomaInventariosNego = new TomaInventariosNegocio();


        ConsultasNegocio ConsultasNego = new ConsultasNegocio();
        ConsultasEntidad ConsultasEnti = new ConsultasEntidad();

        AlmacenNegocio AlmacenNego = new AlmacenNegocio();
        AlmacenEntidad AlmacenEnti = new AlmacenEntidad();

        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
     

        private void AlmacenLlenarDatos()
        {
            try
            {
                ddlList.DataSource     = AlmacenNego.AlmacenDT();
                ddlList.DataTextField  = "AlmacenDes";
                ddlList.DataValueField = "AlmacenCod";
                ddlList.DataBind();
            }
            catch (Exception)
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {

                txtFecha0.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                txtUsuario.Text = Session["rusiausuario"].ToString ();

                
                // DateTime FechaI = Convert.ToDateTime(txtFecha1.Text);
                //FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                //txtFecha1.Text = FechaI.ToString("yyyy-MM-dd");


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
            //txtResponsable.Text = Convert.ToString (ConsultasNego.AlmacenCodigo().tbValor );
  
            TomaInventariosNego.TomaInventariosInsertar(ConsultasNego.AlmacenCodigo().tbValor,
                Convert.ToDateTime(txtFecha0.Text),
                txtUsuario.Text,
                txtResponsable.Text,
                Convert.ToDateTime(txtFecha1.Text),
                Convert.ToDateTime(txtFecha2.Text),
                ddlList.SelectedValue,
                ddlEstado.Text,
                txtObs.Text
                );

            
            txtObs.Text = "";
            txtResponsable.Text = "";
            txtFecha0.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //Response.Write("<script language=javascript>alert('Se Genero Inventario - Ver Reporte');</script>");
            //Response.Redirect("tomainvmenu.aspx");
            hpLink.Text = "Se Genero Inventario - Ver Reporte";
        }

        
        
       


    }
}