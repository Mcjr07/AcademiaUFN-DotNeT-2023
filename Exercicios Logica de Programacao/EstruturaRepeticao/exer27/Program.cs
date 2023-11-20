using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int soma = 0;

        Console.WriteLine("Digite cinco números para calcular a soma:");

        while (contador < 5)
        {
            Console.Write($"Número {contador + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            soma += numero;
            contador++;
        }

        Console.WriteLine($"A soma dos números é: {soma}");
    }
}