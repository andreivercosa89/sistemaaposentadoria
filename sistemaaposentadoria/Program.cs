using System;

namespace sistemaaposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Aposentadoria aposentadoria = new Aposentadoria();

            Console.WriteLine("Infome o Nome: ");
            aposentadoria.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("\nInfome sua Idade: ");
            aposentadoria.Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInfome os anos Trabalhados: ");
            aposentadoria.anosTrabalhados = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n{0} esta {1} para se aposentar.", aposentadoria.Nome, aposentadoria.respostaAposentadoria());
        }
    }
}
