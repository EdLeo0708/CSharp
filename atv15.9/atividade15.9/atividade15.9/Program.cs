using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 6, 4, 13 };

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');

            // Verifica se digitou 4 números
            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números!");
                return; // encerra o programa
            }

            int[] numerosDigitados = new int[4];
            bool entradaValida = true;

            for (int i = 0; i < entrada.Length; i++)
            {
                if (int.TryParse(entrada[i], out int numero))
                {
                    numerosDigitados[i] = numero;
                    continue; // vai para a próxima iteração
                }
                else
                {
                    Console.WriteLine($"A entrada '{entrada[i]}' não é um número válido.");
                    entradaValida = false;
                    break; // sai do laço imediatamente
                }
            }

            if (!entradaValida)
            {
                return; // encerra se teve erro de entrada
            }

            bool senhaCorreta = true;
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (numerosDigitados[i] != listaNumeros[i])
                {
                    senhaCorreta = false;
                    break; // senha errada, não precisa verificar o resto
                }
            }

            if (senhaCorreta)
            {
                Console.WriteLine("Senha correta!");
                Console.WriteLine("Entrando.....");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Comece de Novo!");
            }
        }
    }
}
