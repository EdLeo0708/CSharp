using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int altura = 10; // Definindo a altura do triângulo

            while (i < altura)  // Loop externo que controla o número de linhas
            {
                int j = 0;
                int espacos = altura - i - 1;  // Número de espaços para a esquerda

                // Imprime os espaços antes dos asteriscos
                while (j < espacos)
                {
                    Console.Write(" ");
                    j++;
                }

                // Imprimindo os asteriscos
                j = 0;  // Reinicia a variável j
                while (j <= i)
                {
                    Console.Write("* ");
                    j++;
                }

                Console.WriteLine();  // Pula para a próxima linha
                i++;
            }
        }
    }
}
