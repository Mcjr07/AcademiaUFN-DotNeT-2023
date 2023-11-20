namespace exe16;

class Program
{
    static void Main()
    {
        int[,] matrizOriginal = new int[3, 4] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int[,] matrizTransposta = new int[4, 3];

        // Transpor a matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrizTransposta[j, i] = matrizOriginal[i, j];
            }
        }

        // Exibir a matriz transposta
        Console.WriteLine("Matriz Original:");
        ImprimirMatriz(matrizOriginal);

        Console.WriteLine("\nMatriz Transposta:");
        ImprimirMatriz(matrizTransposta);
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

