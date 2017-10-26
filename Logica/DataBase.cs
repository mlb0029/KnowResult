using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class DataBase
    {
        // Almacenes de datos
        private SortedList<int, Usuario> usuarios = new SortedList<int, Usuario>();
        private SortedList<int, Prueba> pruebas = new SortedList<int, Prueba>();
        private SortedList<int, Calificacion> calificaciones = new SortedList<int, Calificacion>();

        private int usuarioAutonum;
        private int pruebasAutonum;

        public DataBase()
        {
            usuarioAutonum = 0;
            pruebasAutonum = 0;
            this.conectar();
        }

        public Boolean conectar()
        {
            // En este punto se debiera de pregargar los datos necesarios para realizar la conexión.
            // En su lugar cargaremos los datos iniciales según seindica en el enunciado de la práctica.
            return cargaDatosIniciales();
        }


        private bool cargaDatosIniciales()
        {
            // Añade usuarios ASPIRANTES rol=2
            Usuario u;
            u = new Usuario(1, "aperez", "Antonio", "Pérez de Frutos", 2, "a.perez@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(2, "lalvarez", "Lucia", "Álvarez Santaolalla", 2, "l.alvarez@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(3, "celizari", "Carmen", "Elizari Cuasante", 2, "c.elizari@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(4, "alopez", "Alberto", "López Marijuan", 2, "a.lopez@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(5, "emodron", "Emilia", "Modrón Alonso", 2, "e.modron@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(6, "mdelgado", "Maria del Mar", "Delgado Benito", 2, "m.delgado@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(7, "omartinez", "Oscar", "Martínez Ezquerro", 2, "o.martinez@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(8, "pcuesta", "Pedro Luis", "Cuesta Martín", 2, "p.cuesta@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(9, "crubio", "Consuelo", "Rubio Abad", 2, "c.rubio@aspirante.es");
            usuarios.Add(u.GetHashCode(), u);

            // Añade usuarios EVALUADOES rol=1
            u = new Usuario(10, "lalonso", "Laura", "Alonso Renedo", 1, "l.alonso@evaluador.es");
            usuarios.Add(u.GetHashCode(), u);
            u = new Usuario(11, "eblanco", "Elena", "Blanco Alonso", 1, "e.blanco@evaluador.es");
            usuarios.Add(u.GetHashCode(), u);

            // Añade usuarios ADMINISTRADORES rol=0
            u = new Usuario(12, "prenedo", "Pedro", "Renedo Fernández", 0, "prenedo@administrador.es");
            usuarios.Add(u.GetHashCode(), u);

            // Añade pruebas
            Prueba p;
            p = new Prueba(1, "Prueba psicoténcia empresa A", 10);
            pruebas.Add(p.GetHashCode(), p);
            p = new Prueba(2, "Prueba psicoténcia empresa B", 10);
            pruebas.Add(p.GetHashCode(), p);
            p = new Prueba(3, "Prueba física empresa A", 11);
            pruebas.Add(p.GetHashCode(), p);
            p = new Prueba(4, "Prueba física empresa B", 11);
            pruebas.Add(p.GetHashCode(), p);
            p = new Prueba(5, "Prueba psicoténcia empresa C", 10);
            pruebas.Add(p.GetHashCode(), p);

            // Añade calificaciones
            Calificacion c;
            c = new Calificacion(1, 1, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(1, 2, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(1, 3, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(1, 4, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(1, 5, 0, false);
            calificaciones.Add(c.GetHashCode(), c);

            c = new Calificacion(2, 6, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(2, 7, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(2, 8, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(2, 9, 0, false);
            calificaciones.Add(c.GetHashCode(), c);

            c = new Calificacion(3, 1, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(3, 3, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(3, 5, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(3, 7, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(3, 9, 0, false);
            calificaciones.Add(c.GetHashCode(), c);

            c = new Calificacion(4, 2, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(4, 4, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(4, 6, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(4, 8, 0, false);
            calificaciones.Add(c.GetHashCode(), c);

            c = new Calificacion(5, 1, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 2, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 3, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 4, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 5, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 6, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 7, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 8, 0, false);
            calificaciones.Add(c.GetHashCode(), c);
            c = new Calificacion(5, 9, 0, false);
            calificaciones.Add(c.GetHashCode(), c);

            // Se incrementarían antes de cada inserción
            // Para las pruebas se han insertado directamente
            usuarioAutonum = usuarios.Count + 1;
            pruebasAutonum = pruebas.Count + 1;

            return true;

        }

        public int cuentaUsuarios()
        {
            return usuarios.Count;
        }

        public int cuentaPruebas()
        {
            return pruebas.Count;
        }

        public int cuentaCalificaciones()
        {
            return calificaciones.Count;
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

        public Prueba leePrueba(int _idPrueba)
        {
            Prueba retorno = null;
            if(this.pruebas.ContainsKey(_idPrueba))
                retorno = this.pruebas[_idPrueba];
            return retorno;
        }

        public List<Prueba> PruebasAspirante(int _idAspirante)
        {
            List<Prueba> retorno = new List<Prueba>();
            Prueba p = null;
            foreach (Calificacion ca in this.calificaciones.Values)
            {
                if (ca.IdAspirante == _idAspirante)
                {
                    if (pruebas.TryGetValue(ca.IdPrueba, out p)) retorno.Add(p);
                }
            }
            return retorno;
        }

        public List<Calificacion> CalificacionesAspirante(int _idAspirante)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            foreach (Calificacion ca in this.calificaciones.Values)
            {
                if (ca.IdAspirante == _idAspirante) retorno.Add(ca);
            }
            return retorno;
        }

        public List<Calificacion> CalificacionesPrueba(int _idPrueba)
        {
            List<Calificacion> retorno = new List<Calificacion>();
            foreach (Calificacion ca in this.calificaciones.Values)
            {
                if (ca.IdPrueba == _idPrueba) retorno.Add(ca);
            }
            return retorno;
        }
    }
}
