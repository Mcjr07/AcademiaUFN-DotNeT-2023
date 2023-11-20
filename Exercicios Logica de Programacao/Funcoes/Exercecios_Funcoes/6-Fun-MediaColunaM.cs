using System;

class FunCalMed
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int coluna = 1;
        double media = MediaColunaMatriz(matriz, coluna);

        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);
        Console.WriteLine($"Média da coluna {coluna}: {media}");
    }

    static double MediaColunaMatriz(int[,] matriz, int coluna)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);

        for (int i = 0; i < linhas; i++)
        {
            soma += matriz[i, coluna];
        }

        return (double)soma / linhas;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
