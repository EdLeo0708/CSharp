using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Carro : Veiculo
    {
        string modelo;
        public Carro(string placa, string modelo, string cor, string motor)
        {
            capacidadedepessoas = 2;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("000000000000");
        }
    }
}
