using System;

namespace AreaCalculator
{
    internal class Program
    {
        /// <summary>
        /// Imprime um valor numérico no console.
        /// </summary>
        /// <param name="valor">Valor a ser exibido.</param>
        static void Print(double valor)
        {
            Console.WriteLine("Resultado: " + valor);
        }
        /// <summary>
        /// Imprime uma mensagem de texto no console.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida.</param>
        static void Print(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
        /// <summary>
        /// Calcula a área de um círculo.
        /// </summary>
        /// <param name="raio">Raio do círculo.</param>
        /// <returns>Área do círculo.</returns>
        static double CalcularArea(double raio) // Círculo
        {
            return Math.PI * raio * raio;
        }
        /// <summary>
        /// Calcula a área de um triângulo.
        /// </summary>
        /// <param name="b">Base do triângulo.</param>
        /// <param name="h">Altura do triângulo.</param>
        /// <returns>Área do triângulo.</returns>
        static double CalcularArea(double b, double h) // Triângulo
        {
            return (b * h) / 2;
        }
        /// <summary>
        /// Calcula a área de um retângulo.
        /// </summary>
        /// <param name="comprimento">Comprimento do retângulo.</param>
        /// <param name="largura">Largura do retângulo.</param>
        /// <param name="isRetangulo">Parâmetro extra para diferenciar a sobrecarga.</param>
        /// <returns>Área do retângulo.</returns>
        static double CalcularArea(double comprimento, double largura, bool isRetangulo) // Retângulo
        {
            return comprimento * largura;
        }
        /// <summary>
        /// Método principal do programa.
        /// Interage com o usuário, coleta dados e calcula áreas de figuras geométricas.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando.</param>

        static void Main(string[] args)
        {
            // Cumprimento inicial
            Print("Bem-vindo ao programa Calculadora de Áreas!");
            Print("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Print("Olá, " + nome + "! Vamos calcular áreas de formas geométricas.");

            // Menu de seleção
            Print("Escolha a forma que deseja calcular:");
            Print("1 - Círculo");
            Print("2 - Triângulo");
            Print("3 - Retângulo");

            int escolha = Convert.ToInt32(Console.ReadLine());
            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    Print("Digite o raio do círculo:");
                    double raio = Convert.ToDouble(Console.ReadLine());
                    resultado = CalcularArea(raio);
                    break;

                case 2:
                    Print("Digite a base do triângulo:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Print("Digite a altura do triângulo:");
                    double h = Convert.ToDouble(Console.ReadLine());
                    resultado = CalcularArea(b, h);
                    break;

                case 3:
                    Print("Digite o comprimento do retângulo:");
                    double comprimento = Convert.ToDouble(Console.ReadLine());
                    Print("Digite a largura do retângulo:");
                    double largura = Convert.ToDouble(Console.ReadLine());
                    resultado = CalcularArea(comprimento, largura, true);
                    break;

                default:
                    Print("Opção inválida! Reinicie o programa.");
                    return;
            }

            // Exibindo resultado
            Print("A área calculada é:");
            Print(resultado);
        }
    }
}
