class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2) / 2;

        Console.WriteLine("A média aritmética é: " + media);
    }
}
