using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Logica;

namespace www
{
    public partial class AñadirUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario;
            usuario = (Usuario)Session["usuario"];
            if ((usuario == null) || (usuario.Rol != Roles.Administrador))
            {
                Response.Redirect("~/Login.aspx");
                return;
            }
            user.Text = usuario.Cuenta;
            Rol.Text = usuario.Rol.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            if(basededatos.añadeUsuario(TextBox1.Text, TextBox2.Text, TextBox3.Text,(Roles)Enum.Parse(typeof(Roles),DropDownList1.SelectedValue), TextBox4.Text, TextBox6.Text))
            {
                Response.Redirect("~/Menu_Admin.aspx");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu_Admin.aspx");
        }
        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}