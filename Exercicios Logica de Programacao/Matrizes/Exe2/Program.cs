namespace exe2;
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz3x3 = new int[3, 3];

            // Preencha a matriz 3x3 com entrada do usuário
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite um valor para a posição [" + i + "," + j + "]: ");
                    matriz3x3[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Calcule e imprima a soma dos elementos de cada linha
            for (int i = 0; i < 3; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaLinha += matriz3x3[i, j];
                }
                Console.WriteLine("Soma dos elementos da linha " + (i + 1) + ": " + somaLinha);
            }

            // Calcule e imprima a soma dos elementos de cada coluna
            for (int j = 0; j < 3; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < 3; i++)
                {
                    somaColuna += matriz3x3[i, j];
                }
                Console.WriteLine("Soma dos elementos da coluna " + (j + 1) + ": " + somaColuna);
            }
        }
    }
}
