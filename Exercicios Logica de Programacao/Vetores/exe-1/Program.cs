namespace exe1;
{
    public class Program
    {
        static void Main(string[] args)
        {
        
        int[] vetor = new int[10];
        int pares = 0, impares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine($"Números pares: {pares}");
        Console.WriteLine($"Números ímpares: {impares}");    
        }
    }
}
