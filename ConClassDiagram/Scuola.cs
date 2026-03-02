using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es.Slide_370
{
    public class Scuola
    {
        public System.Collections.Generic.List<Studente> Studenti
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.List<Insegnante> Insegnanti
        {
            get => default;
            set
            {
            }
        }

        public double MediaStudente(Studente studente)
        {
            double totaleVoti = 0;
            foreach (var voto in studente.Voti)
            {
                totaleVoti += voto.Valore;
            }

            return totaleVoti / studente.Voti.Count;
        }

        public double[] MediaStudenteAnno(Studente studente, int anno)
        {
            double[] mediaStudenteAnno = new double[12];
            for (int i = 0; i < mediaStudenteAnno.Length; i++)
            {
                double calcoloMedia = 0;
                int numVoti = 0;
                foreach (var voto in studente.Voti)
                {
                    if (voto.Data.Year == anno && voto.Data.Month == i + 1)
                    {
                        calcoloMedia += voto.Valore;
                        numVoti++;
                    }
                }

                if (numVoti == 0)
                {
                    mediaStudenteAnno[i] = 0;
                }
                else
                {
                    mediaStudenteAnno[i] = calcoloMedia / numVoti;
                }
            }

            return mediaStudenteAnno;
        }
    }
}