public class ReservaUpgrade : ReservaRegular
{
    
    public List<String> ComidasDisponiveis = new List<String>();

    public ReservaUpgrade(string cod) : base(cod)
    {

    }

    public void ShowComidasDisponiveis(){

        foreach(var Comidas  in ComidasDisponiveis){

            Console.WriteLine(Comidas);

        }
    }

    
}