using System;

namespace Exerciciosdaescoladeprogramação3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] alturas = new double[15];
            double maior = 0;
            double menor = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite a altura da " + i + " pessoa, em metros: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());

                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("A menor altura da Lista de pessoas é: " + menor + "m, e a maior é: " + maior + "m.");
        }
    }
}
