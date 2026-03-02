namespace SenzaClassDiagram;

public class Voto
{
    public DateTime Data { get; set; }
    public Materia Materia { get; set; }
    public double Valore { get; set; }

    public Voto(DateTime data, Materia materia, double valore)
    {
        Data = data;
        Materia = materia;
        Valore = valore;
    }
}