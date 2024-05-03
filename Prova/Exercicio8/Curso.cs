using System.ComponentModel.Design;

public abstract class Curso
{

    public int SemestreAtual { get; set; }
    public int QuantidadeSemestres { get; set; }
    public double MediaNecessaria { get; set; }
    public List<double> Notas = new List<double>();

    protected Curso()
    {
    }

    protected Curso(int Semestres)
    {

        this.QuantidadeSemestres = Semestres;

    }
    protected Curso(int Semestres, int SemestreAtual)
    {

        this.SemestreAtual = SemestreAtual;
        this.QuantidadeSemestres = Semestres;

    }


    public void AdicionarNotas(double nota)
    {

        this.Notas.Add(nota);

    }

    public virtual double CalcularMedia()
    {

        double TotalNotas = 0;

        foreach (var item in Notas)
        {

            TotalNotas += item;

        }

        return TotalNotas / QuantidadeSemestres;

    }

    public String GerarCertificado()
    {

        if (CalcularMedia() < MediaNecessaria)
        {

            throw new Exception("Media insuficiente para gerar Certificado");

        }

        return "Certificado gerado";

    }

}