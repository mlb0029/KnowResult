using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Usuario
    {
        //ReadOnly
        public int IdUsuario { get; }
        
        public string Cuenta { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string EMail { get; set; }

        public Roles Rol { get; set; }

        public string Password { get; set; }

        public Usuario(int _idUsuario, string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password)
        {
            //Int y Roles no pueden ser nulos. Error de compilación, no en tiempo de ejecución.
            if (_cuenta == null || _nombre == null || _apellidos == null || _eMail == null || _password == null)
                throw new ArgumentNullException();
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

