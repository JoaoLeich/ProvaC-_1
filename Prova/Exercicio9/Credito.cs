public class Credito : IMetodoPagamento
{

    private Boolean isPagoFatura = false; 
    public double CreditoDisponivel { get; set; }

    public void Pagar(double Valor)
    {

        if(this.CreditoDisponivel < Valor){

            throw new Exception("Saldo indisponivel para efetuar pagamento");

        }

        this.CreditoDisponivel -= Valor;
        this.isPagoFatura = true;

    }

    public string StatusPagamento()
    {

        if(this.isPagoFatura){

            return "Fatura paga com sucesso";

        }

        return "Fatura ainda nao paga";

    }
}