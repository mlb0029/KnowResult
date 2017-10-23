using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDusuario
    {
        public BDusuario(int _idUsuario, string _cuenta, string _eMail, string _rol, int _password)
        {
            this.idUsuario = _idUsuario;
            this.cuenta = _cuenta;
            this.eMail = _eMail;
            this.rol = _rol;
            this.password = _password;
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        private string cuenta;

        public string Cuenta
        {
            get { return this.cuenta; }
            set { this.cuenta = value; }
        }

        private string eMail;

            public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        private string rol;

        public string Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }

        private int password;

        public int Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}

