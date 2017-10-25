using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDUsuario
    {
        public int IdUsuario { get; set; } //Permitir cambiar id? Quien?

        public string Cuenta { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string EMail { get; set; }

        public int Rol { get; set; }

        public String Password { get; set; } //Quien puede modificar el password?

        public BDUsuario(int _idUsuario, string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail)
        {
            this.IdUsuario = _idUsuario;
            this.Cuenta = _cuenta;
            this.Nombre = _nombre;
            this.Apellidos = _apellidos;
            this.Rol = _rol;
            this.EMail = _eMail;
            this.Password = "P@ssw0rd";
        }

        public override int GetHashCode()
        {
            return Cuenta.GetHashCode();
        }
    }
}

