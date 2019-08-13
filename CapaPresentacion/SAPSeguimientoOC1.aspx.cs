using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace CapaPresentacion
{
    public partial class SAPSeguimientoOC1 : System.Web.UI.Page
    {
        SAPSeguimientoOCNegocio _SAPSeguimientoOCNegocio = new SAPSeguimientoOCNegocio();
        OpcionNegocio OpcionNego = new OpcionNegocio();
        OpcionEntidad OpcionEnti = new OpcionEntidad();

        string codProveedor = "0", NombreProveedor = "", Solicitud = "0", Orden = "0", Entrada = "0", Factura = "0";

        protected void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            AsignarValores();
            SAPExcel();
        }

        protected void grdSeguimiento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSeguimiento.PageIndex = e.NewPageIndex;
            ListarDatos();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["victorvalerianoquispealegre"] == null) || ((bool)Session["victorvalerianoquispealegre"] == false))

            {
                Response.Redirect("sico.aspx");
            }

            OpcionEnti = OpcionNego.OpcionConsultar(Session["rusiausuario"].ToString(), "OCSeguimiento");
            if ((OpcionEnti.tbValor == 0))
            {

                Response.Write("<script language=javascript>alert('Error : No Tienes Acceso  - QuiebreStock');window.location.href ='menup.aspx';</script>");
            }

            if (!Page.IsPostBack)
            {
                txtFecha1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtFecha2.Text = DateTime.Now.ToString("yyyy-MM-dd");

                DateTime FechaI = Convert.ToDateTime(txtFecha1.Text);

                FechaI = FechaI.AddDays(-1 * DateTime.Now.Day + 1);
                txtFecha1.Text = FechaI.ToString("yyyy-MM-dd");
            }
            ListarDatos();
        }
        private void AsignarValores()
        {
            if (txtxCodProveedor.Text != "")
            {
                codProveedor = txtxCodProveedor.Text;
            }

            if (txtNomProveedor.Text != "")
            {
                NombreProveedor = txtNomProveedor.Text;
            }

            if (txtsolicitud.Text != "")
            {
                Solicitud = txtsolicitud.Text;
            }

            if (txtOrden.Text != "")
            {
                Orden = txtOrden.Text;
            }

            if (txtEntrada.Text != "")
            {
                Entrada = txtEntrada.Text;
            }

            if (txtFactura.Text != "")
            {
                Factura = txtFactura.Text;
            }




        }

        private void ListarDatos()
        {
            try
            {
                AsignarValores();
                grdSeguimiento.DataSource = _SAPSeguimientoOCNegocio.SeguimientoOCDT(Convert.ToDateTime(txtFecha1.Text), Convert.ToDateTime(txtFecha2.Text), codProveedor, NombreProveedor, Solicitud, Orden, Entrada, Factura);
                grdSeguimiento.DataBind();
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
        protected void btnVentaPBuscar_Click(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void SAPExcel()
        {
            // Creamos el archivo
            String Nombre = "SAP"
            + Convert.ToString(DateTime.Now.Day)
            + Convert.ToString(DateTime.Now.Month)
            + Convert.ToString(DateTime.Now.Year)
            + Convert.ToString(DateTime.Now.Hour)
            + Convert.ToString(DateTime.Now.Minute)
            + Convert.ToString(DateTime.Now.Second) + ".xlsx";

            String RutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "\\" + Nombre;

            String RutadeArchivo = @RutaArchivo;

            ExcelPackage ep = new ExcelPackage(new FileInfo(RutadeArchivo));

            //Le añadimos los 'worksheets' que necesitemos.
            //En este caso añadiremos solo uno
            ep.Workbook.Worksheets.Add("Sico");

            //Creamos un objecto tipo ExcelWorksheet para
            //manejarlo facilmente.
            ExcelWorksheet ew1 = ep.Workbook.Worksheets[1];
            AsignarValores();
            ew1.Cells["A1"].LoadFromDataTable(_SAPSeguimientoOCNegocio.SeguimientoOCDT(Convert.ToDateTime(txtFecha1.Text),Convert.ToDateTime(txtFecha2.Text),codProveedor,NombreProveedor,Solicitud,Orden,Entrada,Factura), true);

            ep.Save();
            Response.Redirect("/" + Nombre);

        }
    }
}