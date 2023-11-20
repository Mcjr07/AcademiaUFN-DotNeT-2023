using System;

class FunNumPrimo
{
    static void Main()
    {
        int[] vetor = { 4, 6, 9, 11, 15, 16 };
        bool temPrimo = VerificarNumeroPrimo(vetor);

        Console.WriteLine("Vetor de números:");
        ImprimirVetor(vetor);

        if (temPrimo)
        {
            Console.WriteLine("Pelo menos um número primo está presente no vetor.");
        }
        else
        {
            Console.WriteLine("Nenhum número primo está presente no vetor.");
        }
    }

    static bool VerificarNumeroPrimo(int[] vetor)
    {
        foreach (int num in vetor)
        {
            if (num <= 1)
            {
                continue;
            }

            bool primo = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                return true;
            }
        }
        return false;
    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
