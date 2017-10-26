using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    interface ICapaDatos
    {
        SortedList<int, Usuario> Usuarios { get; set; }
        SortedList<int, Prueba> Pruebas { get; set; }
        SortedList<int, Calificacion> Calificaciones { get; set; }

        Usuario UsuarioActual { get; set; }

        Boolean conectar();
        Boolean cargaDatosIniciales();

        int numUsuarios();
        int numPruebas();
        int numCalifiCaciones();

        Boolean añadeUsuario();//Admin
        Boolean borraUsuario(string _cuenta);//Admin
        Boolean modificaUsuario(string _cuenta);//Admin
        Boolean añadePrueba();//Admin
        Boolean borraPrueba(int _idPrueba);//Admin
        Boolean modificaPrueba(int _idPrueba);//Admin
        Boolean añadeCalificacion();//Admin
        Boolean borraCalificacion(int _idPrueba, string _cuenta);//Admin
        Boolean modificaCalificacion(int _idPrueba, string _cuenta);//Evaluador

        Usuario leeUsuario(string _cuenta);
        Prueba leePrueba(int _idPrueba);
        List<Prueba> PruebasAspirante(int _idAspirante);//Como aspirante quiero ver de que pruebas puedo obtener calificacion
        List<Calificacion> CalificacionesAspirante(int _idAspirante);//Como aspirante quiero ver las calificaciones de mis pruebas
        List<Prueba> PruebasEvaluador(int _idEvaluador);//Como evaluador quiero ver a que pruebas puedo asignar calificaciones
        List<Calificacion> CalificacionesPrueba(int _idPrueba);//Como evaluador, quiero tener acceso a las calificaciones de mi prueba y modificaCalificacion

    }
}
