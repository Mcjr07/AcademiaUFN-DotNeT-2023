namespace exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando um vetor de 5 posições
            int[] vetor = new int[5];

            // Lendo os valores para o vetor
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um valor para a posição " + i + ": ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            // Escrevendo os elementos na ordem original
            Console.WriteLine("\nElementos na ordem original:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            // Escrevendo os elementos na ordem inversa
            Console.WriteLine("\nElementos na ordem inversa:");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.ReadLine(); // Para manter a janela aberta
        }
    }
}

