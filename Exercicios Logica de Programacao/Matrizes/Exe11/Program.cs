namespace exe11;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = new double[3, 3];
            double[,] matrizResultante = new double[3, 3];

            // Preencher a matriz A com valores
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Informe o valor para matrizA[{i}][{j}]: ");
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Calcular a matriz resultante
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizResultante[i, j] = matrizA[i, j] / (i + j);
                }
            }

            // Exibir a matriz resultante
            Console.WriteLine("Matriz Resultante:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizResultante[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}