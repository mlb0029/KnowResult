using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDCalificacion
    {
        private int idPrueba;
        private int idAspirante;
        private Decimal nota;

        public BDCalificacion(int _idPrueba, int _idAspirante, Decimal _nota)
        {
            this.idPrueba = _idPrueba;
            this.idAspirante = _idAspirante;
            this.nota = _nota;

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

        public int IdAspirante
        {
            get { return idAspirante; }
            set { idAspirante = value; }
        }

    }
}
