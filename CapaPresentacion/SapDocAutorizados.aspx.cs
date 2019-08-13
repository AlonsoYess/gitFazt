using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class SapDocAutorizados : System.Web.UI.Page
    {
        SapDocAutorizadosNegocio DocAutorizadosNegocio = new SapDocAutorizadosNegocio();
        SapDocAutorizadosEntidad DocAutorizadosEntidad = new SapDocAutorizadosEntidad();
        OpcionEntidad OpcionEnti = new OpcionEntidad();
        OpcionNegocio OpcionNego = new OpcionNegocio();

        public string ov = "";
        public string CodCliente = "";
        public string CodAlmacen = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))
            {
                Response.Redirect("sico.aspx");
            }
            else
            {

                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "DocAutorizados");
                if ((OpcionEnti.tbValor == 0))
                {

                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Flujo orden de Venta');window.location.href ='menup.aspx';</script>");
                }

                if (!Page.IsPostBack)
                {
                    Timer1.Enabled = true;
                    txtFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtFechaFin.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    //txtNumSAP.Text = "0";
                    //txtCodCliente.Text = "0";
                
                }
                ListarDatos();
            }
        }

        private void ListarDatos()
        {
            try
            {
                if (validaFecha() == 1) {return; }
                validacion();
                grdDocAutorizados.DataSource = DocAutorizadosNegocio.DocumentosAutorizadosConsultar(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFin.Text), ov, CodCliente,ddAlm.SelectedValue.ToString());
                grdDocAutorizados.DataBind();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        private int validaFecha()
        {
            int resultado;
            DateTime dDate;
   
            if (DateTime.TryParse(txtFechaInicio.Text, out dDate) && DateTime.TryParse(txtFechaFin.Text, out dDate))
            {
                 resultado = 0;
            }
            else
            {
                 resultado = 1;
            }


            return resultado;
        }
        private void validacion()
        {

            if (txtNumSAP.Text =="")
            {
                ov = "0";
            }else
            {
                ov = txtNumSAP.Text;
            }
            if (txtCodCliente.Text=="")
            {
                CodCliente = "0";
            }
            else
            {
                CodCliente = txtCodCliente.Text;
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            /**/
            //ListarDatos();
        }

        protected void GridProductoyVentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridProductoyVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarDatos();
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            ListarDatos();
            
        }
    }
}