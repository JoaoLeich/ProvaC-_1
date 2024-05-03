public class Boleto : IMetodoPagamento
{


    public Boolean isPago = false;
    public double valorPagamento = 0;

    public Boleto()
    {
    }

    public Boleto(double ValorPago, string codBarras, string BancoPagamento)
    {

        this.valorPagamento = ValorPago;
        this.CodBarras = codBarras;
        this.BancoPagamento = BancoPagamento;

    }

    public string CodBarras { get; set; }

    public string BancoPagamento { get; set; }

    public void Pagar(double valor)
    {

        if (this.valorPagamento < valor)
        {

            throw new Exception("Valor insuficiente para pagamento");

        }

        this.isPago = true;

    }

    public string StatusPagamento()
    {

        if (this.isPago)
        {

            return $"Boleto pago Banco: {this.BancoPagamento} Cod: {this.CodBarras}";

        }

        return "Boleto nao pago";


    }

}