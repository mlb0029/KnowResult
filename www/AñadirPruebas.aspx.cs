using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace www
{
    public partial class Añadir_Pruebas : System.Web.UI.Page
    {
        public List<Usuario> evaluadores;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["usuario"] == null) || (((Usuario)Session["usuario"]).Rol != Roles.Administrador))
            {
                Session["usuario"] = null;
                Response.Redirect("~/Login");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ICapaDatos a = (ICapaDatos)Session["basededatosactual"];
            if (a != null)
            {
                //a.añadePrueba();
            }
            }
    }
}