//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class minhaClasse
{

	static void Main(string[] args)
	{

		int qtdnumeros = int.Parse(Console.ReadLine());
		string[] numeros = Console.ReadLine().Split(' ');

		int multiplo2 = 0;
		int multiplo3 = 0;
		int multiplo4 = 0;
		int multiplo5 = 0;
		// DONE: Complete os espaços em branco com uma possível solução para o desafio
		for (int iContador = 0; iContador < numeros.Length; iContador++)
		{
			if ((int.Parse(numeros[iContador]) % 2) == 0)
			{
				multiplo2++;
			}
			if ((int.Parse(numeros[iContador]) % 3) == 0)
			{
				multiplo3++;
			}
			if ((int.Parse(numeros[iContador]) % 4) == 0)
			{
				multiplo4++;
			}
			if ((int.Parse(numeros[iContador]) % 5) == 0)
			{
				multiplo5++;
			}
		}

		Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
		Console.WriteLine($"{multiplo3} Multiplo(s) de 3");
		Console.WriteLine($"{multiplo4} Multiplo(s) de 4");
		Console.WriteLine($"{multiplo5} Multiplo(s) de 5");
	}
}