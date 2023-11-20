namespace exer23;

class Program
{
    static void Main()
    {
        double[] valoresGlicemia = new double[3];
        double somaGlicemia = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o valor de glicemia {i + 1}: ");
            valoresGlicemia[i] = Convert.ToDouble(Console.ReadLine());
            somaGlicemia += valoresGlicemia[i];
        }

        double mediaGlicemia = somaGlicemia / 3;

        Console.WriteLine("Análise e Recomendações:");

        for (int i = 0; i < 3; i++)
        {
            if (valoresGlicemia[i] < 65)
                Console.WriteLine($"Valor diário {i + 1}: Risco de hipoglicemia.");

            if (valoresGlicemia[i] > 250)
                Console.WriteLine($"Valor diário {i + 1}: Risco de hiperglicemia.");
        }

        if (mediaGlicemia < 80)
            Console.WriteLine($"Média dos valores: Precisa diminuir 2 unidades de insulina.");

        if (mediaGlicemia > 150)
            Console.WriteLine($"Média dos valores: Será necessário adicionar 2 unidades de insulina.");
    }
}
