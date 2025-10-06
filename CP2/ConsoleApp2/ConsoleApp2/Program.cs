using System;
using System.Collections.Generic;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>
            {
                new Carro(),
                new Caminhao(),
                new Moto()
            };

            foreach (Veiculo i in listaVeiculos)
            {
                i.Acelerar();
            }
        }
    }
}
