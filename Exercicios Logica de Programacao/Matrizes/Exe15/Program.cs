namespace exe15;
class Program
{
    static void Main()
    {
        int[,] matriz1 = new int[4, 4];
        int[,] matriz2 = new int[4, 4];
        int[,] matrizResultado = new int[4, 4];

        // Preencher a primeira matriz com valores
        Console.WriteLine("Preencha a primeira matriz:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Informe o valor para matriz1[{i}][{j}]: ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Preencher a segunda matriz com valores
        Console.WriteLine("Preencha a segunda matriz:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Informe o valor para matriz2[{i}][{j}]: ");
                matriz2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calcular a matriz resultante
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Exibir a matriz resultante
        Console.WriteLine("Matriz Resultante:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrizResultado[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

