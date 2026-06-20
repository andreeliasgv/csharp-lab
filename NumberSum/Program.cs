namespace NumberSum
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=========================================================");
			Console.WriteLine("===================  Soma de Números  ===================");
			Console.WriteLine("=========================================================");

			/* Proposta da Atividade
			 * 
			 * 6) Soma dos números de 1 até N
			 * 
			 * Leia N e calcule a soma de 1 até N.
			 * 
			 * Exemplo:
			 * N = 5 → 1 + 2 + 3 + 4 + 5 = 15
			 * 
			 * Foco: repetição, operadores aritméticos.
			 * 
			 */

			Console.WriteLine();

			int somatoria = 0;

			Console.Write("Digite um número limite para somar com seus antecessores:\n> ");
			int limite = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			for (int i = 1; i <= limite; i++)
			{
				somatoria += i;
			}

			Console.WriteLine($"O resultado é: {somatoria}");
		}
	}
}