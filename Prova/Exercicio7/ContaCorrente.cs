public class ContaCorrente : ContaBase
{


    public ContaCorrente(string NumeroConta) : base(NumeroConta)
    {

        this.LimiteSaque = 10000;

    }

    public Boolean Transferir(ContaBase contaTransferencia,double valor){

       try{ 
        
        contaTransferencia.Depositar(this.Sacar(valor));
        
        }
        catch(Exception ex){

            Console.WriteLine(ex.StackTrace);
            return false;

        }

        return true;

    }


}