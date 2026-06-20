namespace MultiplicationTable
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Proposta da atividade
			 * 3) Tabuada
			 * Peça um número inteiro e mostre a tabuada dele de 1 a 10.
			 * Foco: repetição, operadores aritméticos, variáveis.
			 */

			Console.WriteLine("=================================");
			Console.WriteLine("===========  Tabuada  ===========");
			Console.WriteLine("=================================");
			Console.WriteLine();

			Console.Write("Digite um número inteiro para mostrar sua tabuada:\n> ");
			int numero = Convert.ToInt32(Console.ReadLine());
			int resultado = 0;
			Console.Clear();

			Console.WriteLine($"Tabuada do {numero}:");
			Console.WriteLine();

			for (int i = 1; i <= 10; i++)
			{
				resultado = numero * i;
				Console.WriteLine($"{numero} x {i} = {resultado}");
			}


		}
	}
}