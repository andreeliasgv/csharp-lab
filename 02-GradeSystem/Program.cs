namespace GradeSystem
{
	public class Program
	{

		public static void Main(string[] args)
		{

			/* Proposta da atividade
          *   2) Conversor de notas
          *   Leia uma nota de 0 a 10 e classifique:
          *   0 a 4: reprovado
          *   5 a 6: recuperação
          *   7 a 10: aprovado
          *   Assuntos: condicionais, conversão de tipos, variáveis.
          */

			Console.WriteLine("=====================================");
			Console.WriteLine("= Sistema de Classificação de Notas =");
			Console.WriteLine("=====================================");
			Console.WriteLine();

			Console.Write("Digite a nota do aluno (0 a 10):\n> ");
			int nota = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			if (nota < 0 || nota > 10)
			{
				Console.WriteLine("NOTA INVÁLIDA. Por favor, insira um valor entre 0 e 10.");
			}
			else if
				(nota <= 4)
			{
				Console.WriteLine("REPROVADO");
			}
			else if
				(nota <= 6)
			{
				Console.WriteLine("RECUPERAÇÃO");
			}
			else
			{
				Console.WriteLine("APROVADO");
			}
		}
	}
}
