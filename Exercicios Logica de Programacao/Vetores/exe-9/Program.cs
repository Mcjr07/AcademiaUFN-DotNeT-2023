namespace exe9;
{
    public class Program
    {
        static void Main(string[] args)
        {
           int[] vetor = new int[10];
        int[] vetorOrdenado = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Copiar o vetor original para o vetor auxiliar
        Array.Copy(vetor, vetorOrdenado, 10);

        // Aplicar o algoritmo Bubble Sort para ordenar o vetor auxiliar
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9 - i; j++)
            {
                if (vetorOrdenado[j] > vetorOrdenado[j + 1])
                {
                    int temp = vetorOrdenado[j];
                    vetorOrdenado[j] = vetorOrdenado[j + 1];
                    vetorOrdenado[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Vetor original:");
        foreach (int numero in vetor)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\nVetor ordenado em ordem crescente:");
        foreach (int numero in vetorOrdenado)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine(); 
        }
    }
}