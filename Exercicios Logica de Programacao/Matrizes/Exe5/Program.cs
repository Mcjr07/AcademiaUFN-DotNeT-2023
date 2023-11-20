namespace exe5;
{
    internal class Program
    
    static void Main(string[] args)
    {

        double[,] matriz1 = new double[2, 3];
        double[,] matriz2 = new double[2, 3];

        // Preencha a primeira matriz com entrada do usuário
        Console.WriteLine("Preencha a primeira matriz (2x3):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite um valor para a posição [" + i + "," + j + "]: ");
                matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Preencha a segunda matriz com entrada do usuário
        Console.WriteLine("Preencha a segunda matriz (2x3):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Digite um valor para a posição [" + i + "," + j + "]: ");
                matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Calcule a soma das duas matrizes e imprima o resultado
        double[,] somaMatrizes = new double[2, 3];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Imprima a soma das matrizes
        Console.WriteLine("Soma das matrizes:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(somaMatrizes[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
}
}
