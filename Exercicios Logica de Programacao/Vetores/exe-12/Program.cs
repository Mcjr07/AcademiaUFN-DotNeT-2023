namespace exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            // Preencha o vetor com valores (você pode fazer isso manualmente ou usando um loop)
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o valor para a posição {i}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite o número que você deseja procurar no vetor: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] == numero)
                {
                    Console.WriteLine($"O número {numero} foi encontrado na posição {i} do vetor.");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
        }
    }
}