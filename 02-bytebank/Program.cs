namespace _02_bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();

           
        }
    }
}