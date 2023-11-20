using System;

class MultiMatz
{
    static void Main()
    {
        int[,] matriz1 = {
            {1, 2},
            {3, 4}
        };

        int[,] matriz2 = {
            {5, 6},
            {7, 8}
        };

        int[,] resultado = MultiplicarMatrizes(matriz1, matriz2);

        Console.WriteLine("Matriz 1:");
        ImprimirMatriz(matriz1);

        Console.WriteLine("Matriz 2:");
        ImprimirMatriz(matriz2);

        Console.WriteLine("Resultado da multiplicação das matrizes:");
        ImprimirMatriz(resultado);
    }

    static int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhasMatriz1 = matriz1.GetLength(0);
        int colunasMatriz1 = matriz1.GetLength(1);
        int colunasMatriz2 = matriz2.GetLength(1);

        int[,] resultado = new int[linhasMatriz1, colunasMatriz2];

        for (int i = 0; i < linhasMatriz1; i++)
        {
            for (int j = 0; j < colunasMatriz2; j++)
            {
                resultado[i, j] = 0;
                for (int k = 0; k < colunasMatriz1; k++)
                {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }

        return resultado;
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
