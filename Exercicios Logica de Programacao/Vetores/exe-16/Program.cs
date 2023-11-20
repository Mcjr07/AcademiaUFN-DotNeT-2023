namespace exe16;

internal class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[10];
        int[] Y = new int[10];

        // Lê os elementos do vetor X
        Console.WriteLine("Digite os elementos do vetor X:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("X[" + i + "]: ");
            X[i] = int.Parse(Console.ReadLine());
        }

        // Lê os elementos do vetor Y
        Console.WriteLine("Digite os elementos do vetor Y:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Y[" + i + "]: ");
            Y[i] = int.Parse(Console.ReadLine());
        }

        // Calcula a união de X e Y
        int[] uniao = Union(X, Y);

        // Calcula a diferença entre X e Y
        int[] diferenca = Difference(X, Y);

        // Calcula a interseção entre X e Y
        int[] intersecao = Intersection(X, Y);

        // Imprime os resultados
        Console.WriteLine("União de X e Y:");
        PrintArray(uniao);

        Console.WriteLine("Diferença entre X e Y:");
        PrintArray(diferenca);

        Console.WriteLine("Interseção entre X e Y:");
        PrintArray(intersecao);
    }

    // Função para calcular a união de dois vetores
    static int[] Union(int[] a, int[] b)
    {
        int[] result = new int[20]; // Tamanho máximo é 20 (10 + 10)

        Array.Copy(a, result, 10);
        Array.Copy(b, 0, result, 10, 10);

        return result;
    }

    // Função para calcular a diferença entre dois vetores
    static int[] Difference(int[] a, int[] b)
    {
        int[] result = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (!Array.Exists(b, element => element == a[i]))
            {
                result[i] = a[i];
            }
        }

        return result;
    }

    // Função para calcular a interseção entre dois vetores
    static int[] Intersection(int[] a, int[] b)
    {
        int[] result = new int[10];

        for (int i = 0; i < 10; i++)
        {
            if (Array.Exists(b, element => element == a[i]))
            {
                result[i] = a[i];
            }
        }

        return result;
    }

    // Função para imprimir um vetor
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[" + i + "]: " + arr[i]);
        }
    }
}
    }

