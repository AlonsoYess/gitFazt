using System;
using CapaNegocio;
using CapaEntidad;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        BorrarLogNegocio _BorrarLogNegocio = new BorrarLogNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");

            }
            lblBien.Text = "Bienvenido : " + Session["rusiausuario"];
        }


        protected void stockConsultar_Click(object sender, EventArgs e)
        {
           
                OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "cstock");
                if ((OpcionEnti.tbValor == 1) )
                {

                    Response.Redirect("~/consultastock.aspx");

                }
                else
                {
                    Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ver Consulta de Stock - cstock');</script>");
                 /* Response.Redirect("sico.aspx");*/
                }

        }  
        

        protected void ComprasCotiz_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "compracotiza");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/compracotiz.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Compras vs Cotizaciones - compracotiza');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void VentasGeneral_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "productoyventa");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/productoyventa.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Producto y sus Ventas - productoyventa');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void OrdenxNotaPedido_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "CompraNotaP");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/compraNP.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Compras Vs Nota de Pedido - CompraNotaP');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void SeguimientoSA_Click(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "SeguiDEspacho");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/seguimientosa.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Seguimiento Despacho- SeguiDEspacho');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }


        protected void VentasGC_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGC");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/ventasgc.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGC');</script>");
                /* Response.Redirect("sico.aspx");*/
            }

        }

        protected void VentasGCMARCA_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGCMarca");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/ventasgcmarca.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGCMarca');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void VentasGCFP_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGCFP");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("~/ventasgcformapago.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGCFP');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void vendedorclientes_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "Clientes");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("~/clientes.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas x  Vendedor y Clientes - Clientes');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void logsiticastockmin_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "stockminimo");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("~/LogisticaStockMin.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Consulta - stockminimo');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void cotizacioncliente_Click(object sender, EventArgs e)
        {
            


        }

        protected void cotizacioncliente_Click1(object sender, EventArgs e)
        {
            
            
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "clienteVentaMensualXvendedor");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("~/VentasxClientexMensual.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Consulta - clienteVentaMensualXvendedor');</script>");
                Response.Redirect("menup.aspx");
            }
        
        }

        protected void facturalistado_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "facturalistado");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("~/facturalistado.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Consulta - facturalistado');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
           
        }

        protected void VentasGCExcel_Click(object sender, EventArgs e)
        {

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasGCExcel");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("ventasgcExcel.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - VentasGCExcel');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }



        protected void NotaPedidoListar_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "NotaPedidoListar");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("notapedidolistado.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - NotaPedidoListar');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
            
        }

        protected void GuiaRemision0_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "Compras");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("comprasExcel.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - NotaPedidoListar');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void GuiaRemision_Click(object sender, EventArgs e)
        {
            //guiaspend
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "guiaspend");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("guiaspend.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - guiaspend');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void OrdenCompra_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "Compras");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("ordencompraExcel.aspx");

            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso a Ventas Generales - Compras');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        
        protected void TomaInventario_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "TInventario");
            if ((OpcionEnti.tbValor == 1))
            {
                //Response.Redirect("stockSAP.aspx"); 
                 Response.Redirect("tomainvmenu.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - TInventario');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void VentasGCExcel0_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "ventaslistaprecio");
            if ((OpcionEnti.tbValor == 1))
            {
                //Response.Redirect("stockSAP.aspx"); 
                Response.Redirect("ventaslistaprecio.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - ventaslistaprecio');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void stockConsultar0_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "TIUbicaciones");
            if ((OpcionEnti.tbValor == 1))
            {
                //Response.Redirect("stockSAP.aspx"); 
                Response.Redirect("sapovstock.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - TIUbicaciones');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }

        protected void borrarLog_Click(object sender, EventArgs e)
        {
            
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "BorrarLog");
            if ((OpcionEnti.tbValor == 1))
            {
                int valor = _BorrarLogNegocio.BorrarLog();
                if (valor==1)
                {
                    Response.Write("<script language=javascript>alert('Proceso realizado con éxito - Borrar Log');window.location.href ='menup.aspx';</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('[ERROR] al ejecutar proceso - Borrar Log');window.location.href ='menup.aspx';</script>");
                }
                
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Borrar Log');window.location.href ='menup.aspx';</script>");
            }
        }

        protected void DocAutorizados_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "DocAutorizados");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("SapDocAutorizados.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Flujo orden de Venta');window.location.href ='menup.aspx';</script>");

            }
        }

        protected void VenXFecArt_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VenXFecArt");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("SAPVentasXArticuloExcel.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - Ventas X Fecha y Articulo');window.location.href ='menup.aspx';</script>");

            }
        }

        protected void VentasCliente_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "VentasCliente");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("SAPVentasCliente.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Errorrrr : No Tienes Acceso - Total Ventas X Ultimos Clientes');window.location.href ='menup.aspx';</script>");

            }
        }

        protected void CostoInventario_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "CostoInventario");
            if ((OpcionEnti.tbValor == 1))
            {

                Response.Redirect("SAPCostoIn.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso');window.location.href ='menup.aspx';</script>");

            }
        }

        protected void btnQuiebreStock_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "QuiebreStock");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("SAPQuiebreStock.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - QuiebreStock');window.location.href ='menup.aspx';</script>");
            }
        }

        protected void btnSeguimientoOC_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "OCSeguimiento");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("SAPSeguimientoOC1.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - OCSeguimiento');window.location.href ='menup.aspx';</script>");
            }
        }

        protected void btnSeguimientoOCIMP_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "OCSeguimientoIMP");
            if ((OpcionEnti.tbValor == 1))
            {
                Response.Redirect("SAPSeguimientoOCIMP.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso - OCSeguimientoIMP');window.location.href ='menup.aspx';</script>");
            }
        }

        protected void ConsultarStockMarca_Click(object sender, EventArgs e)
        {
            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "StockXMarca");
            if ((OpcionEnti.tbValor == 1))
            {
                //Response.Redirect("stockSAP.aspx"); 
                Response.Redirect("StockXMarca.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('[Error] : No Tienes Acceso - StockXMarca');</script>");
                /* Response.Redirect("sico.aspx");*/
            }
        }
    }
    }
