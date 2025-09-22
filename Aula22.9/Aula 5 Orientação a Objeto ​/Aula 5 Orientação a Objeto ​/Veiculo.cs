using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5_Orientação_a_Objeto_​
{
    internal class Veiculo
    {
        private string placa;
        private int codFabrica;

        public Veiculo(int codFabrica)
        {
            this.codFabrica = codFabrica;
        }

        public string Placa { get => placa; set => placa = value; }
        /*
        public void Ligar()
        {
            Console.WriteLine("Ligado");
        }
        */
        public void Ligar()
        {
            Console.WriteLine("Ligado");
        }
    }
}
