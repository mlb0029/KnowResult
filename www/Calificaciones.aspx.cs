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
            }
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            List<Calificacion> calificaciones;
            calificaciones = basededatos.calificacionesAspirante(usuario.Cuenta);
            foreach (var item in calificaciones)
            {
                form1.Controls.Add(new Label() { Text = item.Prueba.Nombre + ": " + (item.Calificada ? item.Nota.ToString() : "No calificada") });
            }
        }

       
    }
}