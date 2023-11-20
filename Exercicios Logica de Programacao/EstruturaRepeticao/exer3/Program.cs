namespace exer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int maior = int.MinValue;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"O maior número é: {maior}");
        }
    }
}

