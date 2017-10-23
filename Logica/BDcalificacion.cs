using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDCalificacion
    {
        int idPrueba;
        int idAspirante;
        Decimal nota;
        Boolean calificada;

        public BDCalificacion(int _idPrueba, int _aspirante, Decimal _nota, Boolean _calificada)
        {
            this.idPrueba = _idPrueba;
            this.idAspirante = _aspirante;
            this.nota = _nota;
            this.calificada = _calificada;
        }

        public int IdAspirante
        {
            get { return idAspirante; }
            set { idAspirante = value; }
        }

        public int IdPrueba
        {
            get { return idPrueba; }
            set { idPrueba = value; }
        }

        public Decimal Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public Boolean Calificada
        {
            get { return calificada; }
            set { calificada = value; }
        }

        public override int GetHashCode()
        {
            String st = Convert.ToString(this.idPrueba) + " " + Convert.ToString(this.idAspirante);
            return st.GetHashCode();
        }
    }
}
}
