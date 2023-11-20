namespace exer2
namespace exer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular a tabuada: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int resultado = x * i;
            Console.WriteLine($"{x} x {i} = {resultado}");
        }
           
        }
    }
}

