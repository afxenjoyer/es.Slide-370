using SenzaClassDiagram;
namespace TestScuola
{
    [TestClass]
    public class TestScuola
    {
        [TestMethod]
        public void TestMediaStudente()
        {
            var italiano = new Materia("Italiano", "ITA");
            var studente = new Studente()
            {
                Voti = 
                { 
                    new Voto(DateTime.Now, italiano, 8.5),
                    new Voto(DateTime.Now, italiano, 5.0),
                    new Voto(DateTime.Now, italiano, 7.5)
                }
            };

            Scuola s = new Scuola()
            {
                Studenti = {studente}
            };

            double media = s.MediaStudente(s.Studenti[0]);
            Assert.AreEqual(7, media);
        }

        [TestMethod]
        public void TestMediaStudenteAnno()
        {
            var italiano = new Materia("Italiano", "ITA");
            var studente = new Studente()
            {
                Voti =
                {
                    new Voto(new DateTime(2025, 3, 2), italiano, 8.5),
                    new Voto(new DateTime(2025, 3, 2), italiano, 5.0),
                    new Voto(new DateTime(2026, 1, 2), italiano, 7.5)
                }
            };

            Scuola s = new Scuola()
            {
                Studenti = { studente }
            };

            double[] media = s.MediaStudenteAnno(s.Studenti[0], 2025);
            Assert.AreEqual(6.75, media[2]);
            Assert.AreEqual(0, media[0]);
        }
    }
}