using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Calificacion
    {

        public Prueba Prueba { get; set; }//Prueba debe existir

        public Usuario Aspirante{ get; set; }//Aspirante debe existir

        public Double Nota { get; set; }

        public Boolean Calificada { get; set; }

        public Calificacion(Prueba _prueba, Usuario _aspirante, Double _nota, Boolean _calificada)
        {
            this.Prueba = _prueba;
            this.Aspirante = _aspirante;
            this.Nota = _nota;
            this.Calificada = _calificada;
        }

        public override int GetHashCode()
        {
            String st = Convert.ToString(this.Prueba.IdPrueba) + " " + Convert.ToString(this.Aspirante.IdUsuario);
            return st.GetHashCode();
        }
    }
}
