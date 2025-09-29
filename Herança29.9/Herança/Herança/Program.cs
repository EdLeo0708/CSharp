using Herança;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[4];

            veiculos[0] = new Carro("ABC1234", "Fusca", "Azul", "1.6");
            veiculos[1] = new Moto("DEF5678", "Harley", "Preta", "2.0");
            veiculos[2] = new Carro("GHI9012", "Civic", "Prata", "2.0");
            veiculos[3] = new Pickup("JKL3456", "Ranger", "Branca", "3.2",1000);

            for (int i = 0; i < veiculos.Length; i++)
            {
               veiculos[i].LigarMotor();
               veiculos[i].Abastecer(2);
               Console.WriteLine(veiculos[i].VerificarPessoas());
            }
        }
    }
}