using System;

namespace Number
{
	class Program
	{

		public static void Main(string[] args)
		{
			int n;

			Console.WriteLine("Insira o Valor de N ( 1 a 10 )");
			n = Convert.ToInt32(Console.ReadLine());

			if (n < 11)
            {
				tabuad(n);
				Console.ReadKey(true);
			}
			else
            {
				Console.WriteLine("Valor pode ser apenas de 1 a 10");
			}


		}

		public static void tabuad(int numero)
		{
			for (int x = 1; x <= 10; x++)
			{
				Console.Write(x + " * " + numero + " = " + numero * x + ", ");
			}

		}
	}
}