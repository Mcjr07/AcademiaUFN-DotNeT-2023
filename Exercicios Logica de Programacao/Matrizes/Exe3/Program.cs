namespace exe3;
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz4x4 = new int[4, 4];

            // Preencha a matriz 4x4 com valores de exemplo (ou entrada do usuário)
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz4x4[i, j] = i * 4 + j + 1; // Exemplo de preenchimento
                }
            }

            // Imprima os elementos da diagonal principal
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Elemento da diagonal principal [" + i + "," + i + "]: " + matriz4x4[i, i]);
            }

        }
    }
}