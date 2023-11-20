using System;

class minimamatriz 
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];
        Random random = new Random();

        // Preencher a matriz com valores aleatórios para teste
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = random.Next(1, 101); // Números aleatórios de 1 a 100
            }
        }

        int linhaMinimax, colunaMinimax;
        int minimax = EncontrarMinimax(matriz, out linhaMinimax, out colunaMinimax);

        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);
        Console.WriteLine($"Elemento minimax: {minimax}");
        Console.WriteLine($"Posição na matriz: Linha {linhaMinimax}, Coluna {colunaMinimax}");
    }

    static int EncontrarMinimax(int[,] matriz, out int linhaMinimax, out int colunaMinimax)
    {
        int maxValor = matriz[0, 0];
        linhaMinimax = 0;
        colunaMinimax = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (matriz[i, j] > maxValor)
                {
                    maxValor = matriz[i, j];
                    linhaMinimax = i;
                    colunaMinimax = j;
                }
            }
        }

        int minimax = matriz[linhaMinimax, 0];
        for (int j = 0; j < 10; j++)
        {
            if (matriz[linhaMinimax, j] < minimax)
            {
                minimax = matriz[linhaMinimax, j];
            }
        }

        return minimax;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
