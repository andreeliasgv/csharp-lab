namespace MaxMin
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("==========================================");
			Console.WriteLine("=========  Maior e menor número  =========");
			Console.WriteLine("==========================================");

			Console.WriteLine();

			/* Proposta da Atividade
			 * 
			 * 7) Maior e menor de uma lista
			 * 
			 * Crie uma lista com vários números inteiros e descubra:
			 * o maior valor
			 * o menor valor
			 * 
			 * Foco: listas e repetição.
			 * 
			 */

			int contador = 0;
			List<int> lista = new List<int>();
			int continuar = 1;

			while (continuar == 1)
			{
				contador++;
				Console.Write($"Informe o {contador}º número:\n> ");
				lista.Add(Convert.ToInt32(Console.ReadLine()));

				Console.WriteLine();

				Console.WriteLine("Deseja continuar?");
				Console.WriteLine("(1) - Sim");
				Console.WriteLine("(2) - Não");

				Console.WriteLine();

				continuar = Convert.ToInt32(Console.ReadLine());


				Console.Clear();
			}

			Console.WriteLine("Lista:\n");

			foreach (int numero in lista)
			{
				Console.Write(numero + " ");
			}

			Console.WriteLine("\n");

			Console.WriteLine($"Maior valor da lista: {lista.Max()}");
			Console.WriteLine($"Menor valor da lista: {lista.Min()}");
		}
	}
}