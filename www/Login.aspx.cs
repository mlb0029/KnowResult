using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using Datos;

namespace www
{
    public partial class Login : System.Web.UI.Page
    {
        ICapaDatos basededatos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["basededatos"] == null)
            {
                basededatos = new DBPruebas();
                basededatos.cargaDatosIniciales();
                Session["basededatos"] = basededatos;
            }
            else
            {
                basededatos = (ICapaDatos)Session["basededatos"];
            }
        }

        protected void botonlog_Click(object sender, EventArgs e)
        {
            Usuario usuario = basededatos.leeUsuario(TextBox1.Text);
            LabelError.Text = "";
            if ((usuario == null) || (!basededatos.comprobarContraseña(TextBox1.Text, TextBox2.Text)))
            {
                LabelError.Text = "El usuario o contraseña introducidos no son validos";
            }
            else
            {
                Session["usuario"] = usuario;
                Session["basededatos"] = basededatos;
                switch (usuario.Rol)
                {
                    case Roles.Administrador:
                        Response.Redirect("~/Menu_Admin.aspx");

                        break;
                    case Roles.Evaluador:
                        Response.Redirect("~/IntroducirCalificaciones.aspx");

                        break;
                    case Roles.Aspirante:
                        Response.Redirect("~/Calificaciones.aspx");

                        break;
                    default:
                        Response.Redirect("~/Login.aspx");

                        break;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/recuperar.aspx");
        }
    }
}






 


