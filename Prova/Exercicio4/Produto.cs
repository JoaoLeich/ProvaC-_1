public class Produto
{
    public Produto()
    {

    }

    public Produto(string nome, double preco)
    {

        this.Nome = nome;
        this.Preco = preco;

    }


    public string Nome { get; set; }

    public double Preco { get; set; }

    public int QuantidadeEstoque { get; set; } = 0;



    public Boolean AdicionarProduto(Produto produto)
    {

        if (this.Nome.Equals(produto.Nome))
        {
            this.QuantidadeEstoque++;
            return true;
        }

        return false;

    }

    public void RemoverProduto(Produto produto)
    {

        if (this.QuantidadeEstoque > 0)
        {
            if (this.Nome.Equals(produto.Nome))
            {

                this.QuantidadeEstoque--;
            }

        }

        Console.WriteLine("Produto sem estoque favor adicionar");

    }

    public double CalcularValorProdutoEstoque()
    {

        double valorTotal = (this.Preco) * (this.QuantidadeEstoque);

        return valorTotal;

    }

}