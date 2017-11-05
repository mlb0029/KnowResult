using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace www
{
    public partial class Login : System.Web.UI.Page
    {

        ICapaDatos bd = new DBPruebas();
        
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        
        protected void botonlog_Click(object sender, EventArgs e)
        {
            Usuario usuario = bd.leeUsuario(TextBox1.Text);
            Label1.Text = "";
            if((usuario==null)|| (TextBox2.Text != usuario.Password))
            {
                Label1.Text = "El usuario o contraseña introducidos no son validos";
            }
            else
            {
                Session["usuario"] = usuario;
                switch (usuario.Rol)
                {
                    case Roles.Administrador: Response.Redirect("~/Menu_Admin");
                        break;
                    case Roles.Evaluador: Response.Redirect("~/Menu_Aspi");
                        break;
                    case Roles.Aspirante: Response.Redirect("~/Menu_Eval");
                        break;
                    default: Response.Redirect("~/Login");
                        break;
                }


            }
    }
}