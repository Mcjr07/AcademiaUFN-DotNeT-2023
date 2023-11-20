namespace exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];
            int codigo;

            Console.WriteLine("Digite um código (0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa): ");
            codigo = Convert.ToInt32(Console.ReadLine());

            while (codigo != 0)
            {
                if (codigo == 1)
                {
                    Console.WriteLine("Vetor na ordem em que foi lido:");
                    for (int i = 0; i < 50; i++)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if (codigo == 2)
                {
                    Console.WriteLine("Vetor na ordem inversa:");
                    for (int i = 49; i >= 0; i--)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Código inválido. Digite 0, 1 ou 2.");
                }

                Console.WriteLine("Digite um código (0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa): ");
                codigo = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}

