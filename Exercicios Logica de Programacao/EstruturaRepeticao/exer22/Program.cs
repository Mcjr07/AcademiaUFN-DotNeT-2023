namespace exer22;
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n;
        do
        {
            Console.Write("Digite um número (menor ou igual a 50): ");
            n = int.Parse(Console.ReadLine());

        } while (n > 50);

        int produto = 1;
        while (produto * n < 250)
        {
            produto *= n;
            Console.WriteLine(produto);
        }
    }
}
