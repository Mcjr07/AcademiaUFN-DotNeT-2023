using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

class Desafio //Função que verifica e retorna o menor elemento de um vetor de inteiros:


{
    static void Main()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int menor = EncontrarMenorElemento(vetor);
        Console.WriteLine($"O menor elemento no vetor é: {menor}");
    }

    static int EncontrarMenorElemento(int[] vetor)
    {
        if (vetor.Length == 0)
        {
            return 0; // Se o vetor estiver vazio, retorne 0 (ou outra escolha adequada).
        }

        int menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }
}
