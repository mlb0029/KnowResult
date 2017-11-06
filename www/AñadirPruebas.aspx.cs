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
    public partial class Añadir_Pruebas : System.Web.UI.Page
    {
        public List<Usuario> evaluadores { get; set; }
        public List<Usuario> aspirantes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario;
            usuario = (Usuario)Session["usuario"];
            if ((usuario == null) || (usuario.Rol != Roles.Administrador))
            {
                Response.Redirect("~/Login.aspx");
            }
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            evaluadores = basededatos.listarEvaluadores();
            foreach (var item in evaluadores)
            {
                DropDownList1.Items.Add(new ListItem(item.Nombre, item.Cuenta));
            }

            aspirantes = basededatos.listarAspirantes();
            foreach (var item in aspirantes)
            {
                ListBox1.Items.Add(new ListItem(item.Nombre, item.Cuenta));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            if (basededatos.añadePrueba(TextBox1.Text, DropDownList1.SelectedValue))
            {
                int numerodepruebas=basededatos.numPruebas();
                foreach (ListItem item in ListBox1.Items)
                {
                    if (item.Selected)
                    {
                        basededatos.añadeCalificacion(numerodepruebas,item.Value);

                    }
                }
                

            }
            //Añadir prueba necesito saber que prueba es, recibiendo el id dela prueba creada o algo que no sea un booleano, todo esto para añadirla aspirantes ¿concurrencia?
            Response.Redirect("~/Menu_Admin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu_Admin.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}