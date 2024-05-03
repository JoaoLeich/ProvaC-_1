public interface IReserva
{

    public string StatusReserva(String CodVoo );
    public void Reservar(String CodVoo, String NomePassageiro);
    public void CancelarReserva(String CodVoo);
}