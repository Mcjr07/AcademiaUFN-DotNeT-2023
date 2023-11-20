namespace exer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas: ");
        int n = int.Parse(Console.ReadLine());

        int somaIdades = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite a idade da pessoa {i + 1}: ");
            int idade = int.Parse(Console.ReadLine());
            somaIdades += idade;
        }

        double mediaIdades = (double)somaIdades / n;

        Console.WriteLine($"A média das idades é: {mediaIdades}");
        }
    }
}
