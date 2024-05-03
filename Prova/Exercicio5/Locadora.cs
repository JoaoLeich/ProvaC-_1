using System.Collections;

public class Locadora
{
    public Locadora()
    {


        this.Filmes.Add(new Filme("Harry Potter",
        new List<string> { "", "", },241D));

        this.Filmes.Add(new Filme("Senhor dos Aneis",
        new List<string> { "", "", }, 241D));

        this.Filmes.Add(new Filme("Velozes e Furiosos",
        new List<string> { "", "", }, 241D));

        this.Filmes.Add(new Filme("Os Vingadores",
        new List<string> { "", "", }, 241D));

    }

    public List<Filme> Filmes  = new List<Filme>();

    public void AlugarFilme(string NomeFilme){

        foreach(var filme in this.Filmes){

            if(filme.Disponivel){

                if (filme.Titulo.Equals(NomeFilme)){

                    filme.Disponivel = false;
                    return;

                }
            }
        }

        Console.WriteLine("Filme Indisponivel");
    }

    public void DevolverFilme(string NomeFilme){

        foreach(var Filme in this.Filmes){

            if(Filme.Disponivel == false){

                if(Filme.Titulo.Equals(NomeFilme)){

                    Filme.Disponivel= true;
                    return;

                }
            }
        }

        Console.WriteLine("Filme Nao Encontrado");

    }

}