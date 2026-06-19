using Microsoft.VisualBasic;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Proposta da Atividade
             * 
             * 1) Calculadora simples
             * Crie um programa que receba dois números e mostre:
             * 
             * soma
             * subtração
             * multiplicação
             * divisão
             * 
             * Foco: tipos de dados, variáveis, conversão, operadores aritméticos.
             * 
             */

            #region "Variables"

            double numero1, numero2, resultado = 0.0;
            int operacao;

            #endregion

            #region "Headline"

            Console.WriteLine("=========================");
            Console.WriteLine("== CALCULADORA SIMPLES ==");
            Console.WriteLine("=========================");

            Console.WriteLine();

            Console.WriteLine("Funcionalidades: Adição, Subtração, Multiplicação e Divisão");

            Console.WriteLine();

            #endregion

            Console.Write("Digite o primeiro número:\n> ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine();

            Console.Write("> ");

            operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o segundo número:\n> ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:

                    if (numero2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida!");
                        return;
                    }
                    
            resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operação inválida. Por favor, selecione uma operação válida!");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    }
}