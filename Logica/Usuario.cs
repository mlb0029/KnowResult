using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        public Usuario(int _idUsuario, string _cuenta, string _eMail)
        {
            this.idUsusario = _idUsuario;
            this.cuenta = _cuenta;
            this.eMail = _eMail;
        }

        private int idUsusario;
        public int IdUsuario
        {
            get { return this.idUsusario; }
            set { this.idUsusario = value; }
        }

        private string cuenta;
        public string Cuenta
        {
            get { return this.cuenta; }
            set { this.cuenta = value; }
        }

        private string eMail;
        public string Email
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }


    }
}
