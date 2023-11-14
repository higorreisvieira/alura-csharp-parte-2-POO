using System.Runtime.InteropServices;

namespace _01_bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_gabriela = new ContaCorrente();

            conta_gabriela.titular = "Gabriela";
            conta_gabriela.agencia = 863;
            conta_gabriela.numero = 863452;
            conta_gabriela.saldo = 100;

            Console.WriteLine("Nome do titular: " +conta_gabriela.titular);
            Console.WriteLine("Número da agência: " +conta_gabriela.agencia);
            Console.WriteLine("Número da conta: " +conta_gabriela.numero);
            Console.WriteLine("Saldo da conta: " +conta_gabriela.saldo);

            conta_gabriela += 200; 

            Console.ReadLine();
        }
    }
}