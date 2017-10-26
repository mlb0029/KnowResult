using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Prueba
    {
        public int IdPrueba { get; set; }

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
