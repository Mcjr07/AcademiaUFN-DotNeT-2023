﻿using System;

class SomaMdiagonal
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int somaDiagonal = SomaDiagonalPrincipal(matriz);

        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);
        Console.WriteLine("Soma da diagonal principal: " + somaDiagonal);
    }

    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];
        }
        return soma;
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
