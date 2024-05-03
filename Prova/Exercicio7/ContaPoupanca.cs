public class ContaPoupanca : ContaBase
{
    public ContaPoupanca(string NumeroConta, double juros) : base(NumeroConta)
    {

        this.Juros = Juros;

    }

    public double Juros { get; set; }

    public virtual Boolean Depositar(double valor)
    {

        valor = valor * Juros;

        return this.Depositar(valor);

    }


}