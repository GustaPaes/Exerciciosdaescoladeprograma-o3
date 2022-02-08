using System;

namespace _5_Exerciciosdaescoladeprogramação3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, numero, fatorial;
            Console.WriteLine("Informe o número");
            numero = double.Parse(Console.ReadLine());

            fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"i={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
            Console.ReadLine();

            //conferi o codigo e estou analizando, mas não fui eu que fiz, eu encontrei ele na internet, eu tendo uma dificululdade utilizando o (for)
        }
    }
}