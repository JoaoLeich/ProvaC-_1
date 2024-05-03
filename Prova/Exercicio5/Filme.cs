using System.Collections;

public class Filme{
    public Filme()
    {
    }

    public Filme(string nome,List<String> generos,double duracao)
    {

        this.Titulo = nome;
        this.Generos = generos;
        this.Duracao = duracao;

    }

    public string Titulo { get; set; }  

    public List<String> Generos { get; set; }

    public double Duracao { get; set; }

    public Boolean Disponivel { get; set; } = true;

}