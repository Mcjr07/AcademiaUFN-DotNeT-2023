namespace exer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Digite um número inteiro positivo: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

            Console.WriteLine($"Número digitado: {numero}");
            Console.Write("Números inteiros pares entre 1 e {0}: ", numero);
            for (int i = 2; i <= numero; i += 2)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            do
            {
            Console.Write("Deseja informar outro número (s/n)? ");
            } while (Console.ReadLine().ToLower() == "s");
        }
    }
}
