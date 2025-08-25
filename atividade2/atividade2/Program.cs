using System;

namespace MyApp
{
    internal class Program
    {
        static double r = 0;
        static double a = 0;
        static double b = 0;

        static Program()
        {
            /// Círculo
            Console.WriteLine("Digite o valor do raio:");
            r = Convert.ToDouble(Console.ReadLine());
            a = Math.PI * Math.Pow(r, 2);
            b = 2 * Math.PI * r;
            Console.WriteLine($"A área do círculo é: {a}");
            Console.WriteLine($"O perímetro do círculo é: {b}");
            /// Triângulo
            Console.WriteLine( "digite o valor da altura:");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o valor da base:");
            double base1 = Convert.ToDouble(Console.ReadLine());
            double areaTriangulo = (base1 * altura) / 2;
            Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________");
        }
    }
}