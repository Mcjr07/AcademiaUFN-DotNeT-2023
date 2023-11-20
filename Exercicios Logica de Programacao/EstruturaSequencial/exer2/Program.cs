namespace exer2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Trocar os valores
            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Depois da troca, o valor de A é " + A + " e o valor de B é " + B);

        }
    }
}
