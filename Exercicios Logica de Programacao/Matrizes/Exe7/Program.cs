namespace exe7;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];

            Console.WriteLine("Digite os elementos da matriz A:");
            LerMatriz(matrizA);

            Console.WriteLine("Digite os elementos da matriz B:");
            LerMatriz(matrizB);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}