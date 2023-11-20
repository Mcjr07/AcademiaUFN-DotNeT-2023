namespace exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tamanhoMaximo = 100;
            int[] vetor = new int[tamanhoMaximo];
            int contador2 = 0, contador4 = 0, contador8 = 0;
            int tamanho = 0;

            Console.WriteLine("Digite os números inteiros e positivos (digite -1 para sair ou atingir o limite de posições):");

            for (int i = 0; i < tamanhoMaximo; i++)
            {
                int numero = LerInteiroPositivo();

                if (numero == -1)
                    break;

                vetor[i] = numero;
                tamanho++;

                if (numero == 2)
                    contador2++;
                else if (numero == 4)
                    contador4++;
                else if (numero == 8)
                    contador8++;
            }

            Console.WriteLine($"Quantidade de vezes que o número 2 apareceu: {contador2}");
            Console.WriteLine($"Quantidade de vezes que o número 4 apareceu: {contador4}");
            Console.WriteLine($"Quantidade de vezes que o número 8 apareceu: {contador8}");
        }

        static int LerInteiroPositivo()
        {
            int numero;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0)
                    return numero;
                else
                    Console.WriteLine("Digite um número inteiro positivo válido:");
            }
        }
    }
} 