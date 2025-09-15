namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 5, 6, 4, 13 };
            int numero = 0;
            while (true)
            {
                Console.WriteLine("Tente descobrir um número: ");
                numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < listaNumeros.Length; i++)
                {
                    if (numero == listaNumeros[i])
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        if (i >= listaNumeros.Length - 1)
                        {
                            Console.WriteLine("Você descobriu todos os números!");
                            return;
                        }
                        numero = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Errou!");
                        break;
                    }
                }
            }
        }
    }
}
