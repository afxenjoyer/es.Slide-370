using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es.Slide_370
{
    public class Voto
    {
        public System.DateTime Data
        {
            get => default;
            set
            {
            }
        }

        public double Valore
        {
            get => default;
            set
            {
            }
        }

        public Materia Materia
        {
            get => default;
            set
            {
            }
        }

        public Voto(DateTime data, Materia materia, double valore)
        {
            Data = data;
            Materia = materia;
            Valore = valore;
        }
    }
}