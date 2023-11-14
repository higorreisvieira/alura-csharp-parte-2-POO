namespace _03_bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipos
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta)); 

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));


            if (contaGabriela.saldo >= 100)
            {
                contaGabriela.saldo -= 100;
            }
            Console.ReadLine();
        }
    }
}