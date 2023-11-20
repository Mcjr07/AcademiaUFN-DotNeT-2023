namespace exe4;

public class Program
{
    static void Main(string[] args)
    {
        int tamanho = 10;

        // Inicializando os vetores
        double[] vetor1 = new double[tamanho];
        double[] vetor2 = new double[tamanho];
        double[] vetorResultante = new double[tamanho];

        // Lendo os elementos do primeiro vetor
        Console.WriteLine("Digite os elementos do primeiro vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor1[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Lendo os elementos do segundo vetor
        Console.WriteLine("\nDigite os elementos do segundo vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o elemento {i + 1}: ");
            vetor2[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Multiplicando os elementos de mesmo índice e armazenando no vetor resultante
        for (int i = 0; i < tamanho; i++)
        {
            vetorResultante[i] = vetor1[i] * vetor2[i];
        }

        // Exibindo o vetor resultante
        Console.WriteLine("\nVetor resultante da multiplicação:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Índice {i}: {vetorResultante[i]}");
        }
    }
}

