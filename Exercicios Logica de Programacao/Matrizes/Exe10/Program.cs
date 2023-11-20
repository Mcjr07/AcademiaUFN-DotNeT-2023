namespace exe10;
using System;

class Program
{
    static void Main()
    {
        int tamanhoVetor = 20;
        int[] vetorOriginal = new int[tamanhoVetor];
        int[] vetorResultado = new int[tamanhoVetor];

        // Leitura do vetor original
        Console.WriteLine("Digite os valores do vetor (inteiro) de 20 posições:");
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            vetorOriginal[i] = int.Parse(Console.ReadLine());
        }

        // Copia o vetor original para o vetor resultado e substitui os valores nulos por 2
        for (int i = 0; i < tamanhoVetor; i++)
        {
            if (vetorOriginal[i] == 0)
            {
                vetorResultado[i] = 2;
            }
            else
            {
                vetorResultado[i] = vetorOriginal[i];
            }
        }

        // Mostra o vetor original
        Console.WriteLine("Vetor Original:");
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write(vetorOriginal[i] + " ");
        }

        // Mostra o vetor resultado
        Console.WriteLine("\nVetor Resultado (com valores nulos substituídos por 2):");
        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write(vetorResultado[i] + " ");
        }
    }
}

