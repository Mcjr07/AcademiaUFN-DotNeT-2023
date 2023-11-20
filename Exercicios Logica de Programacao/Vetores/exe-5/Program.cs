using System;

namespace exe5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Defina o tamanho do vetor
            int tamanhoDoVetor = 80;

            // Crie o vetor
            int[] vetor = new int[tamanhoDoVetor];

            // Preencha o vetor com valores fornecidos pelo usuário
            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                Console.Write($"Digite o valor do elemento {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out vetor[i]) == false)
                {
                    Console.WriteLine("Valor inválido. Por favor, insira um número inteiro.");
                    i--;
                }
            }

            // Encontre o menor elemento e sua posição
            int menorElemento = vetor[0];
            int posicaoMenorElemento = 0;

            for (int i = 1; i < tamanhoDoVetor; i++)
            {
                if (vetor[i] < menorElemento)
                {
                    menorElemento = vetor[i];
                    posicaoMenorElemento = i;
                }
            }

            // Mostre o menor elemento e sua posição
            Console.WriteLine($"O menor elemento é {menorElemento} e está na posição {posicaoMenorElemento}.");

            // Aguarde o usuário pressionar Enter antes de encerrar o programa
            Console.ReadLine();
        }
    }
}
