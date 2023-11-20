namespace exe12;
{
   class Program

    static void Main()
    {
        int[,] matriz = new int[4, 3];

        // Preencher a matriz com valores
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Informe o valor para matriz[{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Exibir valores com soma de índices par
        Console.WriteLine("Valores com soma de índices par:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.WriteLine($"matriz[{i}][{j}] = {matriz[i, j]}");
                }
            }
        }
    }
}
}
