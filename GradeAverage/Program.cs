using System.Collections;

namespace GradeAverage
{
	public class Program
	{
		public static void Main(string[] args)
		{

			/* Proposta da atividade
			 * 4) Média de 3 notas
			 * 
			 * Receba três notas de um aluno, calcule a média e informe se ele foi aprovado ou reprovado.
			 * 
			 * Regras sugeridas:
			 * média maior ou igual a 7: aprovado
			 * senão: reprovado
			 * 
			 * Foco: arrays ou variáveis, operadores, condicionais.
			 */

			Console.WriteLine("==========================================");
			Console.WriteLine("===========  Média de 3 Notas  ===========");
			Console.WriteLine("==========================================");

			double[] notas = new double[3];

			Console.WriteLine();

			Console.Write("Digite a primeira nota:\n> ");
			notas[0] = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			Console.Write("Digite a segunda nota:\n> ");
			notas[1] = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			Console.Write("Digite a terceira nota:\n> ");
			notas[2] = Convert.ToDouble(Console.ReadLine());
			Console.Clear();

			double media = (notas[0] + notas[1] + notas[2]) / 3.0;

			Console.WriteLine($"A média das notas é {media}");

			Console.WriteLine();

			if (media >= 7)
			{
				Console.WriteLine("APROVADO");
			} else
			{
				Console.WriteLine("REPROVADO");
			}
		}
	}
}