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
    public partial class IntroducirCalificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario usuario;
            usuario = (Usuario)Session["usuario"];
            if ((usuario == null) || (usuario.Rol != Roles.Evaluador))
            {
                Response.Redirect("~/Login.aspx");
                return;
            }
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            user.Text = usuario.Cuenta;
            Rol.Text = usuario.Rol.ToString();
            var pruebas = basededatos.pruebasEvaluador(usuario.Cuenta);
            foreach (var item in pruebas)
            {
                Boolean flag = true;
                foreach (ListItem item1 in DropDownList1.Items)
                {


                    if (item.IdPrueba.ToString()==item1.Value) {
                        flag = false;
                    }
                }
                if (flag)
                {
                    DropDownList1.Items.Add(new ListItem(item.Nombre, item.IdPrueba.ToString()));
                }
            }
            List<Calificacion> calificaciones = basededatos.calificacionesPrueba(int.Parse(DropDownList1.SelectedValue));
            foreach (var item in calificaciones)
            {
                DropDownList2.Items.Add(new ListItem(item.Aspirante.Nombre, item.Aspirante.Cuenta));
            }
        }
        protected void Cerrar_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            basededatos.modificaCalificacion(int.Parse(DropDownList1.SelectedItem.Value),DropDownList2.SelectedItem.Value,double.Parse(TextBox1.Text));
            TextBox1.Text = string.Empty;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            List<Calificacion> calificaciones = basededatos.calificacionesPrueba(int.Parse(DropDownList1.SelectedValue));
            foreach (var item in calificaciones)
            {
                DropDownList2.Items.Add(new ListItem(item.Aspirante.Nombre,item.Aspirante.Cuenta));
            }
        }

    }
}