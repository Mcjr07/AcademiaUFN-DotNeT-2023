namespace exer23;
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Digite a base: ");
        double baseNumero = double.Parse(Console.ReadLine());

        Console.Write("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseNumero, expoente);
        Console.WriteLine($"{baseNumero}^{expoente} = {resultado}");
        }
    }
}