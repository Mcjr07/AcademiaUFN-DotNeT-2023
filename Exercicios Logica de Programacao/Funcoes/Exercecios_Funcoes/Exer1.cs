using System;


class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Calculadora das 4 operações");
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine($"Resultado: {Soma(num1, num2)}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {Subtracao(num1, num2)}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {Multiplicacao(num1, num2)}");
                break;
            case 4:
                Console.WriteLine($"Resultado: {Divisao(num1, num2)}");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static double Soma(double a, double b)
    {
        return a + b;
    }

    static double Subtracao(double a, double b)
    {
        return a - b;
    }

    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    static double Divisao(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return double.NaN;
        }
        return a / b;
    }
}

