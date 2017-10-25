using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDCalificacion
    {
        public int IdAspirante { get; set; }//Aspirante debe existir

        public int IdPrueba { get; set; }//Prueba debe existir

        public Double Nota { get; set; }

        public Boolean Calificada { get; set; }

        public BDCalificacion(int _idPrueba, int _aspirante, Double _nota, Boolean _calificada)
        {
            this.IdPrueba = _idPrueba;
            this.IdAspirante = _aspirante;
            this.Nota = _nota;
            this.Calificada = _calificada;
        }

        public override int GetHashCode()
        {
            String st = Convert.ToString(this.IdPrueba) + " " + Convert.ToString(this.IdAspirante);
            return st.GetHashCode();
        }
    }
}
