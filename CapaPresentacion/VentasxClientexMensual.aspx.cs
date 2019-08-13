using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class VentasxClientexMensual : System.Web.UI.Page
    {
        VentasxClientexMensualNegocio VentasxClientexMensualNego    = new VentasxClientexMensualNegocio();
        VentasxClientexMensualEntidad VentasxClientexMensualEnti = new VentasxClientexMensualEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        Double suma = 0 ;
        string cliente;
        DateTime fechaIn;
        DateTime fechaFi;
        string ven, cli, empr;
        private void listarDatos()
        {
                ValidaCampo();
                GridProductoyVentas.DataSource = VentasxClientexMensualNego.VentasGeneralesDetalleConsultarDT(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFin.Text),ddVendedor.SelectedValue.ToString(),ddEmpresa.Text,cliente);
                GridProductoyVentas.DataBind();    
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "clienteVentaMensualXvendedor");
            if ((OpcionEnti.tbValor == 0))
            {
            
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - clienteVentaMensualXvendedor');window.location.href ='menup.aspx';</script>");
            }
            if (!Page.IsPostBack)
            {
                txtFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFechaFin.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = Convert.ToDateTime(txtFechaInicio.Text);
                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFechaInicio.Text = FechaI.ToString("yyyy-MM-dd");
            }
        }

        private void ValidaCampo()
        {
            if (txtCliente.Text == "")
            {
                cliente = "0";
            }
            else
            {
                cliente = txtCliente.Text;
            }
        }

        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "clienteVentaMensualXvendedor");
            if ((OpcionEnti.tbValor == 1))
            {
                listarDatos();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta ');</script>");
                /* Response.Redirect("sico.aspx");*/
            }     
        }

        
        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[04].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[05].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[06].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[07].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[08].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[09].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[10].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[11].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[12].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[13].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[14].HorizontalAlign = HorizontalAlign.Right;
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Right;
            /*if (e.Row.RowType == DataControlRowType.DataRow)
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
        
       
        protected void btnVentaPBuscar_Click1(object sender, EventArgs e)
        {
            fechaIn = Convert.ToDateTime(txtFechaInicio.Text);
            fechaFi = Convert.ToDateTime(txtFechaFin.Text);
            ven = ddVendedor.SelectedValue.ToString();
            empr = ddEmpresa.Text;
            listarDatos();
        }

        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Response.Redirect("VentasxClientexMensualD.aspx?datos1=" + fechaIn +
                               "&datos2=" + fechaFi +
                               "&datos3=" + ven +
                               "&datos4=" + this.GridProductoyVentas.Rows[GridProductoyVentas.SelectedIndex].Cells[0].Text +
                               "&datos5=" + empr) ;
        }
    }
}