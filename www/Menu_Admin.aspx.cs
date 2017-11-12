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
    public partial class Menu_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario;
            usuario=(Usuario)Session["usuario"];
            if ((usuario == null)||(usuario.Rol!= Roles.Administrador)) {
                Response.Redirect("~/Login.aspx");
            }
            user.Text = usuario.Cuenta;
            Rol.Text = usuario.Rol.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AñadirPruebas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AñadirUsuario.aspx");
        }

        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}