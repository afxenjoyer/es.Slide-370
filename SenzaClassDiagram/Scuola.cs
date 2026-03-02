namespace SenzaClassDiagram
{
    public class Scuola
    {
        public List<Insegnante> Insegnanti { get; set; } = new List<Insegnante>();
        public List<Studente> Studenti { get; set; } = new List<Studente>();

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