using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDPrueba
    {
        public BDPrueba(int _idPrueba, string _nombre, int _evaluador)
        {
            this.idPrueba = _idPrueba;
            this.nombre = _nombre;
            this.evaluador = _evaluador;
            
        }

        private int idPrueba;

        public int IdPrueba
        {
            get { return this.idPrueba; }
            set { this.idPrueba = value; }
        }

        private string nombre;

        
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private int evaluador;

        public int Evaluador
        {
            get { return this.evaluador; }
            set { this.evaluador = value; }
        }
        


    }
}
