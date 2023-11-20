namespace exe1;

public class Program
{
    static void Main(string[] args)
    {
        int[] vetor1 = new int[20];
        int[] vetor2 = new int[20];
        int[] resultado = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um número para o vetor 1: ");
            vetor1[i] = int.Parse(Console.ReadLine());

            Console.Write("Digite um número para o vetor 2: ");
            vetor2[i] = int.Parse(Console.ReadLine());

            resultado[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("Resultado da soma:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(resultado[i] + " ");
        }
    }
}

