namespace exer14;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
        do
        {
            Console.Write("Digite um número inteiro: ");
        } while (!int.TryParse(Console.ReadLine(), out numero));

        if (numero % 2 == 0)
            Console.WriteLine($"{numero} é par.");
        else
            Console.WriteLine($"{numero} é ímpar.");

        Console.Write("Deseja repetir o programa (s/n)? ");
        if (Console.ReadLine().ToLower() == "s");
        }
    }
}
