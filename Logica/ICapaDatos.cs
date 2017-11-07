using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Logica
{
    public interface ICapaDatos
    {
        Boolean comprobarContraseña(string _cuenta, string _password);
        Boolean cargaDatosIniciales();

        Usuario leeUsuario(string _cuenta);
        //Prueba leePrueba(int _idPrueba);
        //Calificacion leeCalificacion(int _idPrueba, string _cuentaAspirante);

        Boolean añadeUsuario(string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password);//Admin
        //Boolean borraUsuario(string _cuenta);//Admin
        //Boolean modificaUsuario(int id, string _cuenta, string _nombre, string _apellidos, Roles _rol, string _eMail, string _password);//Admin

        Boolean añadePrueba(string _nombre, string _evaluador);//Admin
        //Boolean borraPrueba(int _idPrueba);//Admin
        //Boolean modificaPrueba(int _idPrueba, string _nombre, string _cuenta);//Admin

        Boolean añadeCalificacion(int _idPrueba, string _cuentaAspirante);//Admin
        //Boolean borraCalificacion(int _idPrueba, string _cuenta);//Admin
        Boolean modificaCalificacion(int _idPrueba, string _cuentaAspirante, double _nota);//Evaluador

       
        List<Prueba> pruebasAspirante(string _cuenta);//Como aspirante quiero ver de que pruebas puedo obtener calificacion
        List<Calificacion> calificacionesAspirante(string _cuenta);//Como aspirante quiero ver las calificaciones de mis pruebas

        List<Prueba> pruebasEvaluador(string _cuenta);//Como evaluador quiero ver a que pruebas puedo asignar calificaciones
        List<Usuario> aspirantesPrueba(int _idPrueba);
        List<Calificacion> calificacionesPrueba(int _idPrueba);//Como evaluador, quiero tener acceso a las calificaciones de mi prueba y modificaCalificacion

        List<Usuario> listarEvaluadores();//Como admin quiero ver qué evaluadores puedo asignar a las pruebas
        List<Usuario> listarAspirantes();//Como admin quiero ver qué aspirantes puedo asignar a las pruebas
        List<Prueba> listarPruebas();
    }
}
