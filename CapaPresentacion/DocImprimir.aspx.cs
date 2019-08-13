using System;
using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class DocImprimir : System.Web.UI.Page
    {
        DocNegocio DocNego = new DocNegocio();
        DataTable DocEnti = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            DocEnti = DocNego.DocConsultar(dropEmpresa.SelectedValue.ToString(),dropDocumento.ToString(), txtNumDoc.Text);
            Session["NroFac"] = txtNumDoc.Text;
            Session["TipoDoc"] = dropDocumento.SelectedValue;
            Session["NomEmp"] = dropEmpresa.SelectedValue;
            Response.Redirect("~/Imprimir.aspx");
        }
    }
    }
