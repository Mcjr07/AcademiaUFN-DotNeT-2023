namespace exer18;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }
        Console.WriteLine($"Soma dos cem primeiros números inteiros: {soma}");
    
        }
    }
}
