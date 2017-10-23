﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDUsuario
    {

        public BDUsuario(int _idUsuario, string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail)
        {
            this.idUsuario = _idUsuario;
            this.cuenta = _cuenta;
            this.nombre = _nombre;
            this.apellidos = _apellidos;
            this.eMail = _eMail;
            this.rol = _rol;
            this.password = "P@ssw0rd";
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

        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        private string eMail;

            public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        private int rol;

        public int Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }

        private String password;

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override int GetHashCode()
        {
            return cuenta.GetHashCode();
        }
    }
}

