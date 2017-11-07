using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Prueba
    {
        //ReadOnly
        public int IdPrueba { get; }

        public string Nombre { get; set; }

        public Usuario Evaluador { get; set; }//El evaluador debe existir

        public Prueba(int _idPrueba, string _nombre, Usuario _evaluador)
        {
            this.IdPrueba = _idPrueba;
            this.Nombre = _nombre;
            this.Evaluador = _evaluador;
        }

        public override int GetHashCode()
        {
            return IdPrueba.GetHashCode();
        }
    }
}
