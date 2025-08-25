using System;

namespace MyApp
{
    internal class Program
    {
        static double raio = 0;
        static void Print(string value) {
            Console.WriteLine(value);
        }
        static void Print(double value)
        {
            Console.WriteLine(value);
        }
        static double AreadoCirculo(double value)
        {
            double r = 0 ;
            r = Math.Pow(value, 2) * Math.PI;
            return r;
        }
        static void Main(string[] args)
        {
            Print("Insira o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            double resp = AreadoCirculo(raio);
            Print("Area do circulo "+ resp);
            Print(resp);
        }
    }
}