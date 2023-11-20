using System;

class Program
{
    static int[] vetor = new int[10];

    static void Main()
    {
        LerVetor();
        int pares = ContarPares();
        Console.WriteLine($"O vetor tem {pares} elementos pares.");
    }

    static void LerVetor()
    {
        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int ContarPares()
    {
        int count = 0;

        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
