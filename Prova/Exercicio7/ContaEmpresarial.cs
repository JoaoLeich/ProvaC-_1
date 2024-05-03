public class ContaEmpresarial : ContaCorrente
{

    public double MinSaldo { get; set; }

    public ContaEmpresarial(string NumeroConta, double MinSaldo) : base(NumeroConta)
    {

        this.MinSaldo = MinSaldo;
        this.LimiteSaque = 100000;

    }
    public virtual double Sacar(double ValorSaque)
    {


        if (this.SaldoConta <= 0 && ValorSaque < LimiteSaque && (ValorSaque - MinSaldo) < MinSaldo)
        {

            throw new Exception("Saldo insuficiente para efetuar o saque");

        }


        this.SaldoConta -= ValorSaque;
        return ValorSaque;

    }

}