using System;

public class Program
{
    static void Main()
    {
        // Ler a temperatura em graus Celsius
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        // Calcular a temperatura em graus Fahrenheit
        double fahrenheit = (9 * celsius + 160) / 5;

        // Apresentar o resultado
        Console.WriteLine($"A temperatura em graus Fahrenheit é {fahrenheit}°F");
    }
}