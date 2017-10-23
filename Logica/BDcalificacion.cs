using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class BDcalificacion
    {
        public BDcalificacion(int _idPrueba, int _idAspirante, int _nota)
        {
            this.idPrueba = _idPrueba;
            this.idAspirante = _idAspirante;
            this.nota = _nota;

        }
        private int nota;
        private int idAspirante;
        private int idPrueba;
    }
}
