namespace exe14;
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

        // Verificar se os elementos das diagonais são iguais
        bool diagonaisIguais = true;

        for (int i = 0; i < 5; i++)
        {
            if (matriz[i, i] != matriz[i, 4 - i])
            {
                diagonaisIguais = false;
                break;
            }
        }

        if (diagonaisIguais)
        {
            Console.WriteLine("Os elementos da diagonal principal são iguais aos da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("Os elementos da diagonal principal não são iguais aos da diagonal secundária.");
        }
    }
}

