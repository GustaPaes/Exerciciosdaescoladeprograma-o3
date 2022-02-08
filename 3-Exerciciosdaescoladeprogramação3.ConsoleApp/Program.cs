using System;

namespace _3_Exerciciosdaescoladeprogramação3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1;

            //if (valor % 2 != 0)
            for (int i = 0; i < 249; i++)
            {
                valor = valor + 2;

                if (valor % 3 == 0)
                {
                    Console.WriteLine("Valores de 1 a 250 que são multiplos de 3");
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
