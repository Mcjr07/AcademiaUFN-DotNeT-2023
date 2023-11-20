namespace exe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] vetorOriginal = new int[20];
        int[] vetorInvertido = new int[20];

        // Preencha o vetor original lendo os valores do usuário
        Console.WriteLine("Digite 20 números inteiros:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetorOriginal[i] = int.Parse(Console.ReadLine());
        }

        // Copie os elementos do vetor original para o vetor invertido, invertendo a ordem
        for (int i = 0; i < 20; i++)
        {
            vetorInvertido[i] = vetorOriginal[19 - i];
        }

        // Mostre os conteúdos dos vetores
        Console.WriteLine("Conteúdo do vetor original:");
        foreach (int num in vetorOriginal)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nConteúdo do vetor invertido:");
        foreach (int num in vetorInvertido)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
        }
    }
}