namespace exe13;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];

        // Preencher a matriz com valores
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Informe o valor para matriz[{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Verificar a igualdade das somas
        int somaDiagonalPrincipal = 0;
        int somaDiagonalSecundaria = 0;

        for (int i = 0; i < 5; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
            somaDiagonalSecundaria += matriz[i, 4 - i];
        }

        if (somaDiagonalPrincipal == somaDiagonalSecundaria)
        {
            Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
        }
    }
}

