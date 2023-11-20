using System;

class media
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        double num3 = double.Parse(Console.ReadLine());

        double media = CalcularMedia(num1, num2, num3);
        Console.WriteLine($"A média dos números é: {media}");
    }

    static double CalcularMedia(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
}
