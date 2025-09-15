using System;

static void Main(string[] args)
{
    // Array de números
    int[] listaNumeros = { 5, 6, 4, 13 };

    Console.WriteLine("Digite 4 números separados por espaço:");
    string[] entrada = Console.ReadLine().Split(' ');

    // Verifica se o usuário digitou 4 números
    if (entrada.Length != listaNumeros.Length)
    {
        Console.WriteLine("Você deve digitar exatamente 4 números.");
        return;
    }

    // Converte a entrada para inteiros e verifica se todos os números estão corretos
    bool senhaCorreta = true;
    for (int i = 0; i < listaNumeros.Length; i++)
    {
        if (!int.TryParse(entrada[i], out int numero) || numero != listaNumeros[i])
        {
            senhaCorreta = false;
            break;
        }
    }

    if (senhaCorreta)
    {
        Console.WriteLine("Senha correta! Acesso permitido.");
    }
    else
    {
        Console.WriteLine("Senha incorreta! Acesso negado.");
    }
}