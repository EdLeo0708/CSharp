using cp2_Eercicio_5;
using System;

namespace ExercicioLivro
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro meuLivro = new Livro("Dom Quixote", "Miguel de Cervantes", 1605);
            meuLivro.ExibirInformacoes();

            Console.ReadLine();
        }
    }
}