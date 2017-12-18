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
    public partial class Calificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario;
            usuario = (Usuario)Session["usuario"];
            if ((usuario == null) || (usuario.Rol != Roles.Aspirante))
            {
                Response.Redirect("~/Login.aspx");
                return;
            }
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            List<Calificacion> calificaciones;
            calificaciones = basededatos.calificacionesAspirante(usuario.Cuenta);
            foreach (var item in calificaciones)
            {
                form1.Controls.Add(new Label() { ID = String.Format("Prueba:{0}", item.Prueba.IdPrueba), Width =250, Text = item.Prueba.Nombre +":"});
                form1.Controls.Add(new Label() { ID = String.Format("Calificacion:{0}", item.Prueba.IdPrueba), Width = 200, Text = (item.Calificada ? item.Nota.ToString() : "No calificada") });
                form1.Controls.Add(new LiteralControl("<br/>"));
        }
            user.Text = usuario.Cuenta;
            Rol.Text = usuario.Rol.ToString();
        }
        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("~/Login.aspx");
        }


    }
}