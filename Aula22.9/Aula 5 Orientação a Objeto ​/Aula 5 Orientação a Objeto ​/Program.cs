using Aula_5_Orientação_a_Objeto_;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo(777);
            veiculo.Ligar();
            veiculo.Placa = "ABC-1234";
            Console.WriteLine(veiculo.Placa);
        }
    }
}