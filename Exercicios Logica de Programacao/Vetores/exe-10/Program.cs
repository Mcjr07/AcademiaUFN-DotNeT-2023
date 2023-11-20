namespace exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando e inicializando o vetor de 20 posições
            int[] vetorOriginal = new int[20];

            // Lendo os valores para o vetor
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite o valor para a posição " + i + ": ");
                vetorOriginal[i] = int.Parse(Console.ReadLine());
            }

            // Criando um segundo vetor com os valores substituídos
            int[] vetorResultado = new int[20];
            for (int i = 0; i < 20; i++)
            {
                if (vetorOriginal[i] == 0)
                {
                    vetorResultado[i] = 2;
                }
                else
                {
                    vetorResultado[i] = vetorOriginal[i];
                }
            }

            // Mostrando o vetor original
            Console.WriteLine("\nVetor Original:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetorOriginal[i] + " ");
            }

            // Mostrando o vetor resultado
            Console.WriteLine("\n\nVetor Resultado:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetorResultado[i] + " ");
            }

            Console.ReadLine(); // Para manter a janela aberta
        }
    }
}

