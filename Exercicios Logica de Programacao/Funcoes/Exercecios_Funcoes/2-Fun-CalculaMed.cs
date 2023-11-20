using System;

class CalcuMed
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Média dos números pares: " + CalcularMedia(numeros, true));
        Console.WriteLine("Média dos números ímpares: " + CalcularMedia(numeros, false));
    }

    static double CalcularMedia(int[] vetor, bool pares)
    {
        int soma = 0;
        int quantidade = 0;

        foreach (int num in vetor)
        {
            if (pares && num % 2 == 0)
            {
                soma += num;
                quantidade++;
            }
            else if (!pares && num % 2 != 0)
            {
                soma += num;
                quantidade++;
            }
        }

        if (quantidade == 0)
        {
            return 0.0;
        }

        return (double)soma / quantidade;
    }
}
