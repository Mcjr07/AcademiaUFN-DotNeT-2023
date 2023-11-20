namespace exe8;
{
    internal class Program

    static void Main(string[] args)
    {
        int[,] matriz4x4 = new int[4, 4];

        Console.WriteLine("Digite os elementos da matriz 4x4:");
        LerMatriz(matriz4x4);

        Console.WriteLine("Números na ordem direta:");
        ImprimirMatriz(matriz4x4);

        Console.WriteLine("Números na ordem inversa:");
        ImprimirMatrizInversa(matriz4x4);

    }
}

