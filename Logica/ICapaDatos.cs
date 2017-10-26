using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    interface ICapaDatos
    {
        int numUsuarios();
        int numPruebas();
        int numCalifiCaciones();

        //Boolean conectar();
        bool loggin(Usuario u);
        void logout();
        Boolean cargaDatosIniciales();

        Usuario leeUsuario(int _idUsuario);
        Usuario leeUsuario(string _cuenta);
        Prueba leePrueba(int _idPrueba);
        Calificacion leeCalificacion(Prueba _prueba, Usuario _usuario);

        Boolean añadeUsuario(string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password);//Admin
        Boolean borraUsuario(int _idUsuario);//Admin
        Boolean modificaUsuario(int id, string _cuenta, string _nombre, string _apellidos, int _rol, string _eMail, string _password);//Admin

        Boolean añadePrueba(string _nombre, string _cuenta);//Admin
        Boolean borraPrueba(int _idPrueba);//Admin
        Boolean modificaPrueba(int _idPrueba, string _nombre, string _cuenta);//Admin

        Boolean añadeCalificacion(int _idPrueba, string _cuentaAspirante);//Admin
        Boolean borraCalificacion(int _idPrueba, string _cuenta);//Admin
        Boolean modificaCalificacion(Prueba _prueba, Usuario _aspirante, Double _nota, Boolean _calificada);//Evaluador

       
        List<Prueba> PruebasAspirante(string _cuenta);//Como aspirante quiero ver de que pruebas puedo obtener calificacion
        List<Calificacion> CalificacionesAspirante(string _cuenta);//Como aspirante quiero ver las calificaciones de mis pruebas

        List<Prueba> PruebasEvaluador(string _cuenta);//Como evaluador quiero ver a que pruebas puedo asignar calificaciones
        List<Calificacion> CalificacionesPrueba(int _idPrueba);//Como evaluador, quiero tener acceso a las calificaciones de mi prueba y modificaCalificacion
    }
}
