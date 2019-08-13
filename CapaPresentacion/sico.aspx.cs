using System;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class login : System.Web.UI.Page
    {
        UserNegocio UserNego = new UserNegocio();
        UserEntidad UserEnti = new UserEntidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
                        
            if (this.txtUsuario.Text.Trim() != "" && this.txtClave.Text.Trim() != "" )
            {
                try
                {
                    UserEnti = UserNego.UserConsultar(txtUsuario.Text, txtClave.Text);
                    if ( (UserEnti.tbusuario != "") && (UserEnti.tbusuario != null))
                    {
                        Session["victorvalerianoquispealegre"] = true;
                        Session["rusiausuario"] = txtUsuario.Text;
                        Response.Redirect("~/menup.aspx");

                    }
                    else
                    {
                        lblRespuesta.Text = "Error Usuario/Clave";
                    }

                }
                catch (Exception exc)
                {
                    lblRespuesta.Text = exc.Message.ToString();
                }
            }
            else
            {
                lblRespuesta.Text = "Todo los Campos son Obligatorios.";
            }
        }


    }
}