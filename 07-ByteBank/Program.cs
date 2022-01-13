// See https://aka.ms/new-console-template for more information
namespace _07_ByteBank
{
    class program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(877, 86712540);
                      

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine("O total de contas é: " + ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}
