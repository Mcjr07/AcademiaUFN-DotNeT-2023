namespace exe3;
{
    public class Program
{
    static void Main(string[] args)
    {
        static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero <= 3) return true;
            if (numero % 2 == 0 || numero % 3 == 0) return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            int[] vetor = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Índices dos números primos:");

            for (int i = 0; i < 20; i++)
            {
                if (EhPrimo(vetor[i]))
                    Console.WriteLine($"Número {vetor[i]} na posição {i}");
            }
        }
    }
}
