using System;

class ParImp
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = ParOuImpar(numero);
        Console.WriteLine($"O número é {resultado}");
    }

    static int ParOuImpar(int n)
    {
        if (n % 2 == 0)
        {
            return 0; // Par
        }
        else
        {
            return 1; // Ímpar
        }
    }
}
