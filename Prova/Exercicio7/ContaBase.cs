public abstract class ContaBase
{
    protected ContaBase()
    {
    }

    protected ContaBase(string NumeroConta)
    {

        this.NumeroConta = NumeroConta;

    }

    protected double LimiteSaque = 5000;

    public string NumeroConta { get; set; }

    public double SaldoConta { get; set; } = 0;

    public virtual double Sacar(double ValorSaque)
    {


        if (this.SaldoConta <= 0 && ValorSaque < LimiteSaque)
        {

            throw new Exception("Saldo insuficiente para efetuar o saque");

        }


        this.SaldoConta -= ValorSaque;
        return ValorSaque;

    }

    public virtual Boolean Depositar(double value)
    {

        this.SaldoConta += value;
        return true;

    }

    public void ShowSaldo()
    {

        Console.WriteLine($"Saldo Atual: {0} ", this.SaldoConta);

    }

}