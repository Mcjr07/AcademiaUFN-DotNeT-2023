using System;

class vetormediA
{
    static void Main()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        double media = CalcularMediaVetor(vetor);
        Console.WriteLine($"A média dos números no vetor é: {media}");
    }

    static double CalcularMediaVetor(int[] vetor)
    {
        if (vetor.Length == 0)
        {
            return 0;
        }

        double soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        return soma / vetor.Length;
    }
}
