namespace _04_bytebank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.titular = "Bruno";

            contaBruno.Sacar(500);

            contaBruno.Depositar(500);

            Console.Write(contaBruno.saldo);
        }
    }
}