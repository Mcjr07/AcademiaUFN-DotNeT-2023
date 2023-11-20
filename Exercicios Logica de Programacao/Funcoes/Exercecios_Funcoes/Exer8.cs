
using System;

class n1n2
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());
        int soma = SomarNumerosInteiros(n1, n2);
        Console.WriteLine($"A soma dos números entre {n1} e {n2} é: {soma}");
    }

    static int SomarNumerosInteiros(int n1, int n2)
    {
        int soma = 0;
        for (int i = n1; i <= n2; i++)
        {
            soma += i;
        }
        return soma;
    }
}
