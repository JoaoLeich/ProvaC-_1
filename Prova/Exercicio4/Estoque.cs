public class Estoque
{
    
    public List<Produto> Produtos = new List<Produto>();

    public void AdicionarProduto(Produto ProdutoAdd){

        foreach (Produto produtoItem in Produtos){
            
            if(!produtoItem.AdicionarProduto(ProdutoAdd)){

                this.Produtos.Add(ProdutoAdd); 

            }    
        }
    }

    public void RemoverProduto(Produto ProdutoRmv){

        foreach (Produto produtoItem in Produtos){

            produtoItem.RemoverProduto(ProdutoRmv);

        }   

    }

    public double CalcularProdutosEstoque(){

        double PrecoTotal = 0;

        foreach (var prod in Produtos)
        {
            
            PrecoTotal = prod.CalcularValorProdutoEstoque();

        }

        return PrecoTotal;

    }

}