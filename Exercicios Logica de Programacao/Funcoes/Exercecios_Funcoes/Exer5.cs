using System;

class Celsius
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = ConverterParaFahrenheit(celsius);
        Console.WriteLine($"{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");
    }

    static double ConverterParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
