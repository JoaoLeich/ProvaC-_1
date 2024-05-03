public class ReservaGrupo : ReservaRegular
{

    public void Reservar(String CodVoo,List<String> PassageirosNovos){

        foreach (var item in PassageirosNovos)
        {
            
            this.Passageiros.Add(item);

        }
    }

    
    
}