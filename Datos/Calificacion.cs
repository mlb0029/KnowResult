using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Calificacion
    {
        //ReadOnly
        public Prueba Prueba { get; }

        //ReadOnly
        public Usuario Aspirante{ get; }

        public Double Nota { get; set; }

        public Boolean Calificada { get; set; }

        public Calificacion(Prueba _prueba, Usuario _aspirante)
        {
            if (_prueba == null || _aspirante == null)
                throw new ArgumentNullException();
            this.Prueba = _prueba;
            this.Aspirante = _aspirante;
            //Crear calificación simplemente es asignar aspirante a prueba, no calificar
            this.Nota = 0;
            this.Calificada = false; 
        }

        public override int GetHashCode()
        {
            String st = Convert.ToString(this.Prueba.IdPrueba) + " " + Convert.ToString(this.Aspirante.IdUsuario);
            return st.GetHashCode();
        }
    }
}
