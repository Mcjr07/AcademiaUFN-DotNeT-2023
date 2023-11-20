namespace exe4;
{
    internal class Program

    static void Main(string[] args)
    {

        int[,] matriz5x5 = new int[5, 5];

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        // Preencha a matriz 5x5 com valores de exemplo (ou entrada do usuário)
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz5x5[i, j] = i * 5 + j - 5; // Exemplo de preenchimento
            }
        }

        // Calcule as estatísticas
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int valor = matriz5x5[i, j];
                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }
        }

        // Imprima as estatísticas
        Console.WriteLine("Números pares: " + pares);
        Console.WriteLine("Números ímpares: " + impares);
        Console.WriteLine("Números positivos: " + positivos);
        Console.WriteLine("Números negativos: " + negativos);
        Console.WriteLine("Zeros: " + zeros);

    }
}
}