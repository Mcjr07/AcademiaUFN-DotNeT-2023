namespace exer32;
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Digite três valores:");
        double valor1 = double.Parse(Console.ReadLine());
        double valor2 = double.Parse(Console.ReadLine());
        double valor3 = double.Parse(Console.ReadLine());

        double maior = Math.Max(Math.Max(valor1, valor2), valor3);

        Console.WriteLine("O maior valor é: " + maior);
        }
    }
}
