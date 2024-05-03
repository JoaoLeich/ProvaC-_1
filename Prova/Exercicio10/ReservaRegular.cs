public class ReservaRegular : IReserva
{

    
    private Boolean IsAtivo = true;
    public String CodVoo { get; set; } 

    public List<String> Passageiros = new List<String>();

    public ReservaRegular()
    {
    }

    public ReservaRegular(String cod)
    {

        this.CodVoo = cod;

    }

    public void CancelarReserva(string CodVoo)
    {

        if(this.CodVoo == CodVoo){

            this.IsAtivo = false;

        }

    }

    public void Reservar(string CodVoo, string NomePassageiro)
    {
        
        if(!this.IsAtivo){

            throw new Exception("Voo Cancelado impossivel de reservar");

        }

        Passageiros.Add(NomePassageiro);


    }

    public string StatusReserva(string CodVoo)
    {

        return $"Reseva : {this.CodVoo} Total Pessoas: {this.Passageiros.Count()}";

    }
}