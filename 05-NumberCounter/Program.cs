namespace NumberCounter
{
	class Program
	{
		static void Main(string[] args)
		{

			/* Proposta da atividade
			 * 5) Contador de 1 até N
			 * 
			 * Leia um número inteiro N e mostre todos os números de 1 até N.
			 * 
			 * Foco: repetição, variáveis, conversão.
			 */

			Console.WriteLine("===================================");
			Console.WriteLine("======  Contador de Números  ======");
			Console.WriteLine("===================================");

			Console.WriteLine();

			Console.Write("Escolha um limite para o contador:\n> ");
			int limite = Convert.ToInt32(Console.ReadLine());
			
			Console.Clear();

			for (int i = 1; i <= limite; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}