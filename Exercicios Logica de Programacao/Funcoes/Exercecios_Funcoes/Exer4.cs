using System;

class Fatorial
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = CalcularFatorial(numero);
        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }

    static long CalcularFatorial(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Erro: O fatorial não está definido para números negativos.");
            return -1;
        }
        if (n == 0)
        {
            return 1;
        }
        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
