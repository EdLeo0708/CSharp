using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome1, nome2;
            int i1, i2;

            //Analisando aluno 1:
            Console.WriteLine("Digite o nome do primeiro aluno:"); // Nome
            nome1 = Console.ReadLine(); // Coleta o nome digitado no console
            Console.WriteLine("Digite a Idade do primeiro aluno:"); // Idade
            i1 = int.Parse(Console.ReadLine()); // Coleta a idade digitada no console

            //Pedindo os dados do aluno 2
            Console.WriteLine("Digite o nome do segundo aluno:"); // Nome
            nome2 = Console.ReadLine(); // Coleta a idade digitado no console
            Console.WriteLine("Digite a Idade do segundo aluno:"); // Idade
            i2 = int.Parse(Console.ReadLine()); // Coleta a idade digitada no console

            //Operação para comparar as idades e exibir o resultado
            if (i1 > i2) // Compara SE a idade do aluno 1 é maior que a do aluno 2
            {
                Console.WriteLine("O primeiro aluno de nome: " + nome1 + " que tem: " + i1 + " é mais velho que o segundo aluno de nome: " + nome2 + " que tem: " + i2 + "."); //  Resultado no console
            }
            if (i1 < i2) // Compara SE a idade do aluno 2 é maior que a do aluno 1
            {
                Console.WriteLine("O aluno: " + nome2 + " possui " + i2 + " é mais velho que o primeiro aluno de nome: " + nome1 + " que tem: " + i1 + "."); // Exibe o resultado no console
            }
            if (i1 == i2) // Compara se as idades dos dois alunos são iguais
            {
                Console.WriteLine("Os alunos de nomes: " + nome1 + " e " + nome2 + " têm a mesma idade: " + i1 + "."); // Exibe o resultado no console
            }
        }
    }
}