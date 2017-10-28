using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Cuenta { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string EMail { get; set; }

        public Roles Rol { get; set; }

        public string Password { get; set; }

        public Usuario(int _idUsuario, string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password)
        {
            this.IdUsuario = _idUsuario;
            this.Cuenta = _cuenta;
            this.Nombre = _nombre;
            this.Apellidos = _apellidos;
            this.Rol = _rol;
            this.EMail = _eMail;
            this.Password = _password;
        }

        public override int GetHashCode()
        {
            return Cuenta.GetHashCode();
        }
    }
}

