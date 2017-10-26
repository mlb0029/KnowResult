using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    interface ICapaDatos
    {

        Boolean conectar();
        Boolean cargaDatosIniciales();

        int numUsuarios();
        int numPruebas();
        int numCalifiCaciones();

        Boolean añadeUsuario(string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password);//Admin
        Boolean borraUsuario(string _cuenta);//Admin
        Boolean modificaUsuario(string _cuenta);//Admin
        Boolean añadePrueba(string _nombre, string _cuenta);//Admin
        Boolean borraPrueba(int _idPrueba);//Admin
        Boolean modificaPrueba(int _idPrueba);//Admin
        Boolean añadeCalificacion(int _idPrueba, string _cuentaAspirante);//Admin
        Boolean borraCalificacion(int _idPrueba, string _cuenta);//Admin
        Boolean modificaCalificacion(int _idPrueba, string _cuenta);//Evaluador

        Usuario leeUsuario(string _cuenta);
        Prueba leePrueba(int _idPrueba);
        List<Prueba> PruebasAspirante(string _cuenta);//Como aspirante quiero ver de que pruebas puedo obtener calificacion
        List<Calificacion> CalificacionesAspirante(string _cuenta);//Como aspirante quiero ver las calificaciones de mis pruebas
        List<Prueba> PruebasEvaluador(string _cuenta);//Como evaluador quiero ver a que pruebas puedo asignar calificaciones
        List<Calificacion> CalificacionesPrueba(int _idPrueba);//Como evaluador, quiero tener acceso a las calificaciones de mi prueba y modificaCalificacion

    }
}
