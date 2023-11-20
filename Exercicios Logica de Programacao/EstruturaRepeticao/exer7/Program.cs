namespace exer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosPares = 0;
        int numerosImpares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numerosPares++;
            }
            else
            {
                numerosImpares++;
            }
        }

        Console.WriteLine($"Números pares: {numerosPares}");
        Console.WriteLine($"Números ímpares: {numerosImpares}");
    
        }
    }
}