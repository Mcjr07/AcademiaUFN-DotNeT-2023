namespace exer19;
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int somaPares = 0;
        for (int i = 2; i <= 500; i += 2)
        {
            somaPares += i;
        }
        Console.WriteLine($"Somatório dos valores pares entre 1 e 500: {somaPares}");
    
        }
    }
}
