namespace exer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Digite o valor de x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        int y = int.Parse(Console.ReadLine());

        int resultado = 1;

        for (int i = 0; i < y; i++)
        {
            resultado *= x;
        }

        Console.WriteLine($"{x} elevado a {y} é igual a {resultado}");  
        }
    }
}


