namespace exe6;
{
    internal class Program

    static void Main(string[] args)
    {

        int[,] matriz = new int[4, 4];
        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = random.Next(0, 10);
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int maiorNumero = EncontrarMaiorNumero(matriz);
        Console.WriteLine("O maior número da matriz é: " + maiorNumero);

    }
}
}
