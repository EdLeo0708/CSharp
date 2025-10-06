using System;

namespace Veiculos
{
    public class Caminhao : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Caminhão acelerando lentamente...");
        }
    }
}
