using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class DBPruebas : ICapaDatos
    {
        private SortedList<int, Usuario> usuarios = new SortedList<int, Usuario>();
        private SortedList<int, Prueba> pruebas = new SortedList<int, Prueba>();
        private SortedList<int, Calificacion> calificaciones = new SortedList<int, Calificacion>();

        private Usuario usuarioActual;

        public Prueba leePrueba(int _idPrueba)
        {
            Prueba retorno = null;
            if(this.pruebas.ContainsKey(_idPrueba))
                retorno = this.pruebas[_idPrueba];
            return retorno;
        }

        public Usuario leeUsuario(string _cuenta)
        {
            Usuario retorno = null;
            foreach (Usuario u in this.usuarios.Values)
            {
                if (u.Cuenta.Equals(_cuenta))
                {
                    retorno = u;
                    break;
                }
            }
            return retorno;
        }

        public bool añadeCalificacion(int _idPrueba, string _cuentaAspirante)
        {
            Prueba prueba = leePrueba(_idPrueba);
            Usuario aspirante = leeUsuario(_cuentaAspirante);
            if (prueba != null && aspirante != null && aspirante.Rol == 2)
            {
                Calificacion c = new Calificacion(prueba, aspirante, 0, false);//Que pasa si repito?
                calificaciones.Add(c.GetHashCode(), c);
                return true;
            }
            return false;
        }

        public bool añadePrueba(string _nombre, string _cuenta)
        {
            Usuario evaluador = leeUsuario(_cuenta);
            int id;
            if (evaluador != null && evaluador.Rol == 1)
            {
                Prueba p = new Prueba(numPruebas(), _nombre, evaluador);
                pruebas.Add(p.GetHashCode(), p);
                return true;
            }
            return false;
        }

        public bool añadeUsuario(string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u.Equals(null))
            {
                u = new Usuario(numUsuarios(), _cuenta, _nombre, _apellidos, _rol, _eMail, _password);
                usuarios.Add(u.GetHashCode(), u);
                return true;
            }
            return false;
           
        }

        public bool borraCalificacion(int _idPrueba, string _cuenta)//Es como quitar a un aspirante de una prueba
        {
            throw new NotImplementedException();
        }

        public bool borraPrueba(int _idPrueba)
        {
            Prueba p = leePrueba(_idPrueba);
            if (p != null)
            {
                pruebas.Remove(_idPrueba);
                return true;
            }
            return false;
        }

        public bool borraUsuario(string _cuenta)
        {
            Usuario u = leeUsuario(_cuenta);
            if (u != null)
            {
                usuarios.Remove(u.IdUsuario);
                return true;
            }
            return false;
        }

        public List<Calificacion> CalificacionesAspirante(string _cuenta)
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

        public List<Calificacion> CalificacionesPrueba(int _idPrueba)
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

        public bool cargaDatosIniciales()
        {
            throw new NotImplementedException();
        }

        public bool conectar()
        {
            throw new NotImplementedException();
        }

        

        public bool modificaCalificacion(int _idPrueba, string _cuenta)
        {
            throw new NotImplementedException();
        }

        public bool modificaPrueba(int _idPrueba)
        {
            throw new NotImplementedException();
        }

        public bool modificaUsuario(string _cuenta)
        {
            throw new NotImplementedException();
        }

        public int numCalifiCaciones()
        {
            throw new NotImplementedException();
        }

        public int numPruebas()
        {
            return pruebas.Count;
        }

        public int numUsuarios()
        {
            return usuarios.Count;
        }

        public List<Prueba> PruebasAspirante(string _cuenta)
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

        public List<Prueba> PruebasEvaluador(string _cuenta)
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
    }
}
