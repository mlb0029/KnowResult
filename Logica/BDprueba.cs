using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDPrueba
    {
        public int IdPrueba { get; set; }//Permitir cambiar id? Quien?

        public string Nombre { get; set; }

        public int Evaluador { get; set; }//El evaluador debe existir

        public BDPrueba(int _idPrueba, string _nombre, int _evaluador)
        {
            this.IdPrueba = _idPrueba;
            this.Nombre = _nombre;
            this.Evaluador = _evaluador;
            
        }
    }
}
