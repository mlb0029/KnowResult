using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Logica
{
    public class DBPruebas : ICapaDatos
    {
        private SortedList<int, Usuario> usuarios;
        private SortedList<int, Prueba> pruebas;
        private SortedList<int, Calificacion> calificaciones;

        private int idU;
        private int idP;

        public DBPruebas()
        {
            //cargaDatosIniciales();
        }

        public Boolean comprobarContraseña(string _cuenta, string _password)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u != null && u.Password.Equals(_password))
                return true;
            return false;
        }

        public Boolean cargaDatosIniciales()
        {
            this.usuarios = new SortedList<int, Usuario>();
            this.pruebas = new SortedList<int, Prueba>();
            this.calificaciones = new SortedList<int, Calificacion>();
            this.idU = 0;
            this.idP = 0;
            // Añade usuarios ADMINISTRADORES rol=0
            añadeUsuario("prenedo", "Pedro", "Renedo Fernández", Roles.Administrador, "prenedo@administrador.es", "prene");
            // Añade usuarios EVALUADOES rol=1
            añadeUsuario("lalonso", "Laura", "Alonso Renedo", Roles.Evaluador, "l.alonso@evaluador.es", "lau");
            añadeUsuario("eblanco", "Elena", "Blanco Alonso", Roles.Evaluador, "e.blanco@evaluador.es", "passwd2");
            // Añade usuarios ASPIRANTES rol=2
            añadeUsuario("aperez", "Antonio", "Pérez de Frutos", Roles.Aspirante, "a.perez@aspirante.es", "passwd3");
            añadeUsuario("lalvarez", "Lucia", "Álvarez Santaolalla", Roles.Aspirante, "l.alvarez@aspirante.es", "passwd4");
            añadeUsuario("celizari", "Carmen", "Elizari Cuasante", Roles.Aspirante, "c.elizari@aspirante.es", "passwd5");
            añadeUsuario("alopez", "Alberto", "López Marijuan", Roles.Aspirante, "a.lopez@aspirante.es", "passwd6");
            añadeUsuario("emodron", "Emilia", "Modrón Alonso", Roles.Aspirante, "e.modron@aspirante.es", "passwd7");
            añadeUsuario("mdelgado", "Maria del Mar", "Delgado Benito", Roles.Aspirante, "m.delgado@aspirante.es", "passwd8");
            añadeUsuario("omartinez", "Oscar", "Martínez Ezquerro", Roles.Aspirante, "o.martinez@aspirante.es", "passwd9");
            añadeUsuario("pcuesta", "Pedro Luis", "Cuesta Martín", Roles.Aspirante, "p.cuesta@aspirante.es", "passwd10");
            añadeUsuario("crubio", "Consuelo", "Rubio Abad", Roles.Aspirante, "c.rubio@aspirante.es", "passwd11");

            // Añade pruebas
            añadePrueba("Prueba psicoténcia empresa A", "lalonso");
            añadePrueba("Prueba psicoténcia empresa B", "lalonso");
            añadePrueba("Prueba física empresa A", "eblanco");
            añadePrueba("Prueba física empresa B", "eblanco");
            añadePrueba("Prueba psicoténcia empresa C", "lalonso");

            // Añade calificaciones
            añadeCalificacion(0, "aperez");
            añadeCalificacion(0, "lalvarez");
            añadeCalificacion(0, "celizari");
            añadeCalificacion(0, "alopez");
            añadeCalificacion(0, "emodron");

            añadeCalificacion(1, "mdelgado");
            añadeCalificacion(1, "omartinez");
            añadeCalificacion(1, "pcuesta");
            añadeCalificacion(1, "crubio");

            añadeCalificacion(2, "aperez");
            añadeCalificacion(2, "celizari");
            añadeCalificacion(2, "emodron");
            añadeCalificacion(2, "omartinez");
            añadeCalificacion(2, "crubio");

            añadeCalificacion(3, "lalvarez");
            añadeCalificacion(3, "alopez");
            añadeCalificacion(3, "mdelgado");
            añadeCalificacion(3, "pcuesta");

            añadeCalificacion(4, "aperez");
            añadeCalificacion(4, "lalvarez");
            añadeCalificacion(4, "celizari");
            añadeCalificacion(4, "alopez");
            añadeCalificacion(4, "emodron");
            añadeCalificacion(4, "mdelgado");
            añadeCalificacion(4, "omartinez");
            añadeCalificacion(4, "pcuesta");
            añadeCalificacion(4, "crubio");

            //Algunas pruebas calificadas
            modificaCalificacion(0, "aperez", 5.5);
            modificaCalificacion(4, "aperez", 8.8);
            modificaCalificacion(0, "lalvarez", 6.3);
            modificaCalificacion(4, "lalvarez", 6.3);
            modificaCalificacion(0, "celizari", 7.5);
            modificaCalificacion(2, "celizari", 6.6);
            modificaCalificacion(4, "celizari", 7.2);
            modificaCalificacion(0, "alopez", 8.9);
            modificaCalificacion(4, "alopez", 2.2);
            modificaCalificacion(0, "emodron", 4.3);
            modificaCalificacion(2, "emodron", 7.8);
            modificaCalificacion(4, "emodron", 4.7);
            modificaCalificacion(4, "mdelgado", 8.3);
            modificaCalificacion(2, "omartinez", 9.2);
            modificaCalificacion(4, "omartinez", 2.1);
            modificaCalificacion(4, "pcuesta", 5);
            modificaCalificacion(2, "crubio", 9.6);
            modificaCalificacion(4, "crubio", 6.8);
            return true;
        }

        public Usuario leeUsuario(string _cuenta)
        {
            foreach (Usuario u in usuarios.Values)
                if (u.Cuenta == _cuenta)
                    return u;
            return null;
        }
        
        private Prueba leePrueba(int _idPrueba)
        {
            if (pruebas.ContainsKey(_idPrueba))
                return pruebas[_idPrueba];
            return null;
        }

        private Calificacion leeCalificacion(int _idPrueba, string _cuentaAspirante)
        {
            foreach (Calificacion ca in calificaciones.Values)
                if (ca.Prueba.IdPrueba.Equals(_idPrueba) && ca.Aspirante.Cuenta == _cuentaAspirante)
                    return ca;
            return null;
        }

        public Boolean añadeUsuario(string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u == null)
            {
                u = new Usuario(idU++, _cuenta, _nombre, _apellidos, _rol, _eMail, _password);
                usuarios.Add(u.GetHashCode(), u);
                return true;
            }
            return false;
        }

        private Boolean borraUsuario(string _cuenta)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                usuarios.Remove(u.GetHashCode());
                return true;
            }
            return false;
        }

        private Boolean modificaUsuario(string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                u.Nombre = _nombre;
                u.Apellidos = _apellidos;
                u.Rol = _rol;
                u.EMail = _eMail;
                u.Password = _password;
                return true;
            }
            return false;
        }

        public Boolean añadePrueba(string _nombre, string _cuenta)
        {
            Usuario evaluador = leeUsuario(_cuenta);
            if (evaluador != null && evaluador.Rol == Roles.Evaluador && _nombre != null && _nombre != "")
            {
                foreach (Prueba p in pruebas.Values)
                    if (p.Nombre.Equals(_nombre))
                        return false;
                Prueba prueba = new Prueba(idP++, _nombre, evaluador);
                pruebas.Add(prueba.GetHashCode(), prueba);
                return true;
            }
            return false;
        }

        private Boolean borraPrueba(int _idPrueba)
        {
            if (pruebas.ContainsKey(_idPrueba))
            {
                pruebas.Remove(_idPrueba);
                return true;
            }
            return false;
        }

        private Boolean modificaPrueba(int _idPrueba, string _nombre, string _cuenta)
        {
            Usuario evaluador = leeUsuario(_cuenta);
            if (pruebas.ContainsKey(_idPrueba) && evaluador != null && evaluador.Rol == Roles.Evaluador)
            {
                pruebas[_idPrueba].Nombre = _nombre;
                pruebas[_idPrueba].Evaluador = evaluador;
                return true;
            }
            return false;
        }

        public Boolean añadeCalificacion(int _idPrueba, string _cuentaAspirante)
        {
            Prueba prueba = leePrueba(_idPrueba);
            Usuario aspirante = leeUsuario(_cuentaAspirante);
            if (prueba != null && aspirante != null && aspirante.Rol.Equals(Roles.Aspirante) && leeCalificacion(_idPrueba, _cuentaAspirante) == null)
            {
                Calificacion c = new Calificacion(prueba, aspirante);
                calificaciones.Add(c.GetHashCode(), c);
                return true;
            }
            return false;
        }

        private Boolean borraCalificacion(int _idPrueba, string _cuentaAspirante)//Es como quitar a un aspirante de una prueba
        {
            Calificacion c;
            c = leeCalificacion(_idPrueba, _cuentaAspirante);
            if (c != null)
            {
                calificaciones.Remove(c.GetHashCode());
                return true;
            }
            return false;
        }

        public Boolean modificaCalificacion(int _idPrueba, string _cuentaAspirante, double _nota)
        {
            Calificacion c = leeCalificacion(_idPrueba, _cuentaAspirante);
            if (c != null)
            {
                c.Nota = _nota;
                c.Calificada = true;
                return true;
            }
            return false;
        }

        public List<Prueba> pruebasAspirante(string _cuenta)
        {
            List<Prueba> retorno = new List<Prueba>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
                foreach (Calificacion ca in calificaciones.Values)
                    if (ca.Aspirante == u)
                        retorno.Add(ca.Prueba);
            return retorno;
        }

        public List<Calificacion> calificacionesAspirante(string _cuenta)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
                foreach (Calificacion c in calificaciones.Values)
                    if (c.Aspirante == u)
                        retorno.Add(c);
            return retorno;
        }

        public List<Prueba> pruebasEvaluador(string _cuenta)
        {
            List<Prueba> retorno = new List<Prueba>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
                foreach (Prueba ca in pruebas.Values)
                    if (ca.Evaluador == u)
                        retorno.Add(ca);
            return retorno;
        }

        public List<Usuario> aspirantesPrueba(int _idPrueba)
        {
            List<Usuario> retorno = new List<Usuario>();
            Prueba p = leePrueba(_idPrueba);
            if (p != null)
                foreach (Calificacion ca in calificaciones.Values)
                    if (ca.Prueba == p)
                        retorno.Add(ca.Aspirante);
            return retorno;
        }

        public List<Calificacion> calificacionesPrueba(int _idPrueba)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            Prueba p = leePrueba(_idPrueba);
            if (p != null)
                foreach (Calificacion c in calificaciones.Values)
                    if (c.Prueba == p)
                        retorno.Add(c);
            return retorno;
        }

        public List<Usuario> listarEvaluadores()
        {
            List<Usuario> retorno = new List<Usuario>();
            foreach (Usuario u in usuarios.Values)
                if (u.Rol == Roles.Evaluador)
                    retorno.Add(u);
            return retorno;
        }

        public List<Usuario> listarAspirantes()
        {
            List<Usuario> retorno = new List<Usuario>();
            foreach (Usuario u in usuarios.Values)
                if (u.Rol == Roles.Aspirante)
                    retorno.Add(u);
            return retorno;
        }

        public List<Prueba> listarPruebas()
        {
            return new List<Prueba>(pruebas.Values);
        }
    }
}