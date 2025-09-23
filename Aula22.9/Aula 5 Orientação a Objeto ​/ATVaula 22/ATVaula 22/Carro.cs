using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVaula_22
{
    internal class Carro
    {   // Propriedades
        public string Chassis { get; set; }
        public string LicensePlate { get; set; }
        public string Cor { get; set; }
        public string Motor { get; set; }

        // Construtor
        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }

        // Método para exibir os detalhes do carro
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Detalhes do carro: Chassis: {Chassis}, Placa: {LicensePlate}, Cor: {Cor}, Motor: {Motor}");
        }
    }
}