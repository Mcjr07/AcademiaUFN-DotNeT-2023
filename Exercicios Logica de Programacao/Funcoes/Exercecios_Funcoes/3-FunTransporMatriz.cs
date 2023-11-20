using System;

class TransporFun
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrizTransposta = TransporMatriz(matriz);

        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matriz);
        Console.WriteLine("Matriz Transposta:");
        ImprimirMatriz(matrizTransposta);
    }

    static int[,] TransporMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int[,] matrizTransposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizTransposta[j, i] = matriz[i, j];
            }
        }

        return matrizTransposta;
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
