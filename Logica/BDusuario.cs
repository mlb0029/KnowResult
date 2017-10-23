using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDUsuario
    {
        public BDUsuario(int _idUsuario, string _cuenta, string _eMail)
        {
            this.idUsuario = _idUsuario;
            this.cuenta = _cuenta;
            this.eMail = _eMail;
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
    }

}

