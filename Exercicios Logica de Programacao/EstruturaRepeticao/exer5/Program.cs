namespace exer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"O fatorial de {n} é {fatorial}");
        }
    }
}
