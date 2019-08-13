using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{


    public partial class ventasgcmarca : System.Web.UI.Page
    {
        VentasGCMarcaNegocio VentasGCNego = new VentasGCMarcaNegocio();
        VentasGCMarcaEntidad VentasGCEnti = new VentasGCMarcaEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma0 = 0 ;
        Double suma1 = 0;
        Double suma2 = 0;
        Double suma3 = 0;
        Double suma4 = 0;
        Double suma5 = 0;
        Double suma6 = 0;


        private void VentasGCListarPL()
        {
            try
            {
                GridVentasGCMarca.DataSource = VentasGCNego.VentasGCMarcaListarCDatos(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text),ddEmpresa.Text);
                GridVentasGCMarca.DataBind();
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

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGCMarca");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - VentasGCMarca');window.location.href ='menup.aspx';</script>");
            }


            if (!Page.IsPostBack)
            {
                txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = Convert.ToDateTime(txtFecha1.Text);

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFecha1.Text = FechaI.ToString("yyyy-MM-dd");
            }
           // txtFecha1.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // txtFecha2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            VentasGCListarPL();
        }

        
        protected void GridVentasGCMarca_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[3].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[5].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[7].HorizontalAlign = HorizontalAlign.Right;


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                suma0 = suma0 + Convert.ToDouble(e.Row.Cells[1].Text);
                suma1 = suma1 + Convert.ToDouble(e.Row.Cells[2].Text);
                suma2 = suma2 + Convert.ToDouble(e.Row.Cells[3].Text);
                suma3 = suma3 + Convert.ToDouble(e.Row.Cells[4].Text);
                suma4 = suma4 + Convert.ToDouble(e.Row.Cells[5].Text);
                suma5 = suma5 + Convert.ToDouble(e.Row.Cells[6].Text);
                suma6 = suma6 + Convert.ToDouble(e.Row.Cells[7].Text);

            }
            else
            {
                if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[0].Text = "Total :";

                    e.Row.Cells[1].Text = suma0.ToString("N");
                    e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[2].Text = suma1.ToString("N");
                    e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[3].Text = suma2.ToString("N");
                    e.Row.Cells[3].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[4].Text = suma3.ToString("N");
                    e.Row.Cells[4].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[5].Text = suma4.ToString("N");
                    e.Row.Cells[5].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[6].Text = suma5.ToString("N");
                    e.Row.Cells[6].HorizontalAlign = HorizontalAlign.Right;

                    e.Row.Cells[7].Text = suma6.ToString("N");
                    e.Row.Cells[7].HorizontalAlign = HorizontalAlign.Right;

                }
                    
            }
                     
        }
        /*
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/menup.aspx");
        }
        
        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "100")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "tvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - tvendedordet');</script>");
                    
                }
            }

            if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "200")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "mvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - mvendedordet');</script>");
                 
                }
            }

            if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "300")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "rvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - rvendedordet');</script>");
                    
                }
            }

            if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "400")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
             
                }
            }

            if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "950")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cvendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - cvendedordet');</script>");
                   
                }
            }

            if (this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text == "998")
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ovendedordet");
                if ((OpcionEnti.tbValor == 1))
                {

                    Response.Redirect("ventasgcpv.aspx?datos1=" + txtFecha1.Text.ToString() + "&datos2=" + txtFecha2.Text.ToString() + "&datos3=" + this.GridVentasGCMarca.Rows[GridVentasGCMarca.SelectedIndex].Cells[0].Text);


                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver este Detalle - ovendedordet');</script>");
                  
                }
            }
        }
        */

        protected void txtFecha1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}