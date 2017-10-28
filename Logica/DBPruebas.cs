using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class DBPruebas : ICapaDatos
    {
        private SortedList<int, Usuario> usuarios;
        private SortedList<int, Prueba> pruebas;
        private SortedList<int, Calificacion> calificaciones;

        private int idU;
        private int idP;

        private Usuario usuarioActual;
        public Usuario UsuarioActual { get { return usuarioActual; } }

        public DBPruebas()
        {
            usuarioActual = null;
            cargaDatosIniciales();
        }

        public int numUsuarios()
        {
            return usuarios.Count;
        }

        public int numPruebas()
        {
            return pruebas.Count;
        }

        public int numCalifiCaciones()
        {
            return calificaciones.Count;
        }

        public bool loggin(String _cuenta)
        {
            Usuario u = leeUsuario(_cuenta);
            if (this.usuarioActual == null && u != null)
            {
                this.usuarioActual = u;
                return true;
            }
            return false;
        }

        public void logout()
        {
            usuarioActual = null;
        }

        public bool cargaDatosIniciales()
        {
            this.usuarios = new SortedList<int, Usuario>();
            this.pruebas = new SortedList<int, Prueba>();
            this.calificaciones = new SortedList<int, Calificacion>();
            this.idU = 0;
            this.idP = 0;
            // Añade usuarios ADMINISTRADORES rol=0
            añadeUsuario("prenedo", "Pedro", "Renedo Fernández", 0, "prenedo@administrador.es", "passwd0");
            // Añade usuarios EVALUADOES rol=1
            añadeUsuario("lalonso", "Laura", "Alonso Renedo", 1, "l.alonso@evaluador.es", "passwd1");
            añadeUsuario("eblanco", "Elena", "Blanco Alonso", 1, "e.blanco@evaluador.es", "passwd2");
            // Añade usuarios ASPIRANTES rol=2
            añadeUsuario("aperez", "Antonio", "Pérez de Frutos", 2, "a.perez@aspirante.es", "passwd3");
            añadeUsuario("lalvarez", "Lucia", "Álvarez Santaolalla", 2, "l.alvarez@aspirante.es", "passwd4");
            añadeUsuario("celizari", "Carmen", "Elizari Cuasante", 2, "c.elizari@aspirante.es", "passwd5");
            añadeUsuario("alopez", "Alberto", "López Marijuan", 2, "a.lopez@aspirante.es", "passwd6");
            añadeUsuario("emodron", "Emilia", "Modrón Alonso", 2, "e.modron@aspirante.es", "passwd7");
            añadeUsuario("mdelgado", "Maria del Mar", "Delgado Benito", 2, "m.delgado@aspirante.es", "passwd8");
            añadeUsuario("omartinez", "Oscar", "Martínez Ezquerro", 2, "o.martinez@aspirante.es", "passwd9");
            añadeUsuario("pcuesta", "Pedro Luis", "Cuesta Martín", 2, "p.cuesta@aspirante.es", "passwd10");
            añadeUsuario("crubio", "Consuelo", "Rubio Abad", 2, "c.rubio@aspirante.es", "passwd11");

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

            return true;
        }

        public Usuario leeUsuario(int _idUsuario)
        {
            foreach (Usuario u in usuarios.Values)
            {
                if (u.IdUsuario.Equals(_idUsuario))
                {
                    return u;
                }
            }
            return null;
        }

        public Usuario leeUsuario(string _cuenta)
        {
            foreach (Usuario u in usuarios.Values)
            {
                if (u.Cuenta.Equals(_cuenta))
                {
                    return u;
                }
            }
            return null;
        }

        public Prueba leePrueba(int _idPrueba)
        {
            Prueba retorno = null;
            if (this.pruebas.ContainsKey(_idPrueba))
                retorno = this.pruebas[_idPrueba];
            return retorno;
        }

        public Calificacion leeCalificacion(Prueba _prueba, Usuario _usuario)
        {
            foreach (Calificacion ca in calificaciones.Values)
            {
                if (ca.Prueba.Equals(_prueba) && ca.Aspirante.Equals(_usuario))
                    return ca;
            }
            return null;
        }

        public bool añadeUsuario(string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password)
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

        public bool borraUsuario(int _idUsuario)
        {
            Usuario u = leeUsuario(_idUsuario);
            if (u != null)
            {
                usuarios.Remove(_idUsuario);
                return true;
            }
            return false;
        }

        public bool modificaUsuario(int id, string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                u.Cuenta = _cuenta;
                u.Nombre = _nombre;
                u.Apellidos = _apellidos;
                u.Rol = _rol;
                u.EMail = _eMail;
                u.Password = _password;
                return true;
            }
            return false;
        }

        public bool añadePrueba(string _nombre, string _cuenta)
        {
            Usuario evaluador = leeUsuario(_cuenta);
            if (evaluador != null && evaluador.Rol == 1)
            {
                Prueba p = new Prueba(idP++, _nombre, evaluador);
                pruebas.Add(p.GetHashCode(), p);
                return true;
            }
            return false;
        }

        public bool borraPrueba(int _idPrueba)
        {
            if (pruebas.ContainsKey(_idPrueba))
            {
                pruebas.Remove(_idPrueba);
                return true;
            }
            return false;
        }

        public bool modificaPrueba(int _idPrueba, string _nombre, string _cuenta)
        {
            Usuario evaluador = leeUsuario(_cuenta);
            if (pruebas.ContainsKey(_idPrueba) && evaluador != null && evaluador.Rol == 1)
            {
                pruebas[_idPrueba].Nombre = _nombre;
                pruebas[_idPrueba].Evaluador = evaluador;
                return true;
            }
            return false;
        }

        public bool añadeCalificacion(int _idPrueba, string _cuentaAspirante)
        {
            Prueba prueba = leePrueba(_idPrueba);
            Usuario aspirante = leeUsuario(_cuentaAspirante);
            Calificacion c;
            if (prueba != null && aspirante != null && aspirante.Rol == 2)
            {
                c = leeCalificacion(prueba, aspirante);
                if (c == null)
                {
                    c = new Calificacion(prueba, aspirante, 0, false);
                    calificaciones.Add(c.GetHashCode(), c);
                    return true;
                }
            }
            return false;
        }

        public bool borraCalificacion(int _idPrueba, string _cuentaAspirante)//Es como quitar a un aspirante de una prueba
        {
            Prueba prueba = leePrueba(_idPrueba);
            Usuario aspirante = leeUsuario(_cuentaAspirante);
            Calificacion c;
            if (prueba != null && aspirante != null && aspirante.Rol == 2)
            {
                c = leeCalificacion(prueba, aspirante);
                if (!c.Equals(null))
                {
                    calificaciones.Remove(c.GetHashCode());
                }
            }
            return false;
        }

        public bool modificaCalificacion(Prueba _prueba, Usuario _aspirante, Double _nota, Boolean _calificada)
        {
            Calificacion c = leeCalificacion(_prueba, _aspirante);
            if (!c.Equals(null))
            {
                c.Nota = _nota;
                c.Calificada = _calificada;
                return true;
            }
            return false;
        }

        public List<Prueba> pruebasAspirante(string _cuenta)
        {
            List<Prueba> retorno = new List<Prueba>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                foreach (Calificacion ca in calificaciones.Values)
                {
                    if (ca.Aspirante == u)
                        retorno.Add(ca.Prueba);
                }
            }
            return retorno;
        }

        public List<Calificacion> calificacionesAspirante(string _cuenta)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                foreach (Calificacion c in calificaciones.Values)
                {
                    if (c.Aspirante == u)
                        retorno.Add(c);
                }
            }
            return retorno;
        }

        public List<Prueba> pruebasEvaluador(string _cuenta)
        {
            List<Prueba> retorno = new List<Prueba>();
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                foreach (Calificacion ca in calificaciones.Values)
                {
                    if (ca.Prueba.Evaluador == u)
                        retorno.Add(ca.Prueba);
                }
            }
            return retorno;
        }

        public List<Calificacion> calificacionesPrueba(int _idPrueba)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            Prueba p = leePrueba(_idPrueba);
            if (p != null)
            {
                foreach (Calificacion c in calificaciones.Values)
                {
                    if (c.Prueba == p)
                        retorno.Add(c);
                }
            }
            return retorno;
        }

        public List<Usuario> listarEvaluadores()
        {
            List<Usuario> retorno = new List<Usuario>();
            foreach (Usuario u in usuarios.Values)
            {
                if (u.Rol == 1)
                {
                    retorno.Add(u);
                }
            }
            return retorno;
        }

        public List<Usuario> listarAspirantes()
        {
            List<Usuario> retorno = new List<Usuario>();
            foreach (Usuario u in usuarios.Values)
            {
                if (u.Rol == 2)
                {
                    retorno.Add(u);
                }
            }
            return retorno;
        }
    }
}