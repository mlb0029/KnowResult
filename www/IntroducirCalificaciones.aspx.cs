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
            List<TextBox> textboxes = Panel1.Controls.OfType<TextBox>().ToList();
            for(int cont=0;cont<textboxes.Count;cont+=2){ 
            basededatos.modificaCalificacion(int.Parse(DropDownList1.SelectedItem.Value), textboxes[cont+1].Text, double.Parse(textboxes[cont].Text));
        }
            for(int cont1 = 0;Request.Form["cuenta" + cont1]!=null;cont1++){

            }
            //Request.Form[]
            Response.Redirect("~/Login.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICapaDatos basededatos;
            basededatos = (ICapaDatos)Session["basededatos"];
            List<Calificacion> calificaciones = basededatos.calificacionesPrueba(int.Parse(DropDownList1.SelectedValue));
            int cont=0;
            foreach (var item in calificaciones)
            {

                //form1.Controls.AddAt(form1.Controls.IndexOf(Button1), new Label() { Width = 250, Text = item.Aspirante.Nombre + " " + item.Aspirante.Apellidos + ":" });
                Panel1.Controls.Add(new Label() { Width = 250, Text = item.Aspirante.Nombre + " " + item.Aspirante.Apellidos + ":" });
                Panel1.Controls.Add(new TextBox() {ID="nota"+cont, Width = 200, TextMode = TextBoxMode.Number });
                Panel1.Controls.Add(new LiteralControl("<br/>"));
                Panel1.Controls.Add(new LiteralControl("<input type='hidden' name='cuenta"+cont+"' value='"+item.Aspirante.Cuenta+"'/>"));
                Panel1.Controls.Add(new TextBox() {ID="cuenta"+ cont,Text=item.Aspirante.Cuenta,Visible=false});
                cont++;
            }
           


            }
          
        
    }
}