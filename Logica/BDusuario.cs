using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDUsuario
    {
<<<<<<< HEAD
        public BDusuario(int _idUsuario, string _cuenta, string _eMail, string _rol, int _password)
=======
        public BDUsuario(int _idUsuario, string _cuenta, string _eMail)
>>>>>>> ba2676e9a37b445d2c67c896ff965ba18eb1743b
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

