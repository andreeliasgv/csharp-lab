using System.Security.Cryptography.X509Certificates;

namespace GuessingGame
{
	public class Program
	{

		public static void VerificarChute(int pnChute, int pnResposta, int pnTentativas)
		{
			if (pnChute == pnResposta)
			{
				Console.Clear();
				Console.WriteLine("Parabéns, você acertou!");
				Console.WriteLine($"Resposta = {pnResposta}");
				Console.WriteLine($"Tentativas = {pnTentativas}");
			}
			else if
				(pnChute > pnResposta)
			{
				Console.Clear();
				Console.WriteLine("Muito alto, tente novamente!");
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Muito baixo, tente novamente!");
			}
		}

		static void Main(string[] args)
		{
			/* Proposta da Atividade
			 * 
			 * 8) Jogo de adivinhação simples
			 * 
			 * O programa escolhe um número fixo, por exemplo 7.
			 * O usuário tenta adivinhar.
			 * 
			 * Mostre:
			 * 
			 * "muito alto" se o chute for maior
			 * "muito baixo" se o chute for menor
			 * "acertou" se for igual
			 * 
			 * Foco: condicionais, variáveis, tipos de dados.
			 * 
			 */

			int resposta = Random.Shared.Next(10);
			int chute = 0;
			int tentativa = 1;

			while(true)
			{
			Console.WriteLine("===========================================");
			Console.WriteLine("==========  Jogo de Adivinhação  ==========");
			Console.WriteLine("===========================================");

			Console.WriteLine();

			Console.WriteLine($"Tentativa n°{tentativa}\n");

				Console.WriteLine("Um número foi selecionado. Qual é o seu chute?");
				Console.Write("Digite um número para continuar:\n> ");
				chute = Convert.ToInt32(Console.ReadLine());

				VerificarChute(chute, resposta, tentativa);
				if (chute == resposta) { break; }
				Thread.Sleep(1500);
				Console.Clear();

				tentativa++;
			}

		}
		
	}
}