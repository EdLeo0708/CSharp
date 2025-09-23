using System;

namespace ATVaula_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de 10 carros
            Carro[] carList = new Carro[10];
            carList[0] = new Carro("Sedan", "ABC123", "Vermelho", "V6");
            carList[1] = new Carro("SUV", "XYZ789", "Azul", "Elétrico");
            carList[2] = new Carro("Hatchback", "LMN456", "Preto", "1.6 Flex");
            carList[3] = new Carro("Pickup", "QWE321", "Branco", "V8");
            carList[4] = new Carro("Conversível", "RTY654", "Amarelo", "2.0 Turbo");
            carList[5] = new Carro("Coupé", "UIO987", "Cinza", "V6 Biturbo");
            carList[6] = new Carro("Minivan", "JKL741", "Prata", "2.4 Flex");
            carList[7] = new Carro("Sedan", "FGH852", "Azul Escuro", "Híbrido");
            carList[8] = new Carro("SUV", "BNM963", "Verde", "Diesel 3.0");
            carList[9] = new Carro("Hatchback", "PQR159", "Laranja", "Elétrico");

            // Exibindo os Dados de cada carro
            foreach (Carro carro in carList)
            {
                carro.MostrarDetalhes();
            }
            // Manter o console aberto até o usuário pressionar uma tecla
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
