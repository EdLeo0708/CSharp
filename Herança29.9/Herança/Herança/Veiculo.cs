using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Veiculo
    {
        protected string placa;
        protected string cor;
        protected string chassi;
        protected string motor;
        protected int pessoas;
        bool motor_ligado;
        public int capacidadedepessoas;
        public float estadodoTanque;

        public void LigarMotor()
        {
            motor_ligado = true;
        }
        public void DesligarMotor()
        {
            motor_ligado = false;
        }
        public int EsdodoTanque()
        {
            return (int)(estadodoTanque* 100);
        }

        public void Abastecer(int Pessoas)
        {
            if (Pessoas > capacidadedepessoas)
            { 
                Console.WriteLine("Veículo não pode ser abastecido com mais pessoas do que sua capacidade.");
            }
            this.pessoas = Pessoas;
        }
        public String VerificarPessoas()
        {
            return $"Existem {this.pessoas} no {this.GetType().Name} contando com o motorista.";
        }
    }
}
