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
        DBPruebas bd;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.bd= new DBPruebas();
        }

        protected void cuadroLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
        }
    }
}