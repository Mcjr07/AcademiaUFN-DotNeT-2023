namespace exe17;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];
        Random rand = new Random();

        // Preencher a matriz com valores aleatórios
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matriz[i, j] = rand.Next(1, 101); // Valores de 1 a 100 para exemplo
            }
        }

        // Encontrar o elemento minimax
        int linhaMax = 0;
        int colunaMax = 0;
        int maximo = matriz[0, 0];
        int minimax = matriz[0, 0];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                    linhaMax = i;
                    colunaMax = j;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (matriz[linhaMax, i] < minimax)
            {
                minimax = matriz[linhaMax, i];
            }
        }

        // Exibir resultados
        Console.WriteLine("Matriz:");
        ImprimirMatriz(matriz);

        Console.WriteLine($"\nElemento minimax: {minimax}");
        Console.WriteLine($"Linha do máximo: {linhaMax}");
        Console.WriteLine($"Coluna do máximo: {colunaMax}");
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

