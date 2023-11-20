namespace EXER12;
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int idade;
        do
        {
            Console.Write("Digite a idade (maior que zero): ");
        } while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0);

        Console.WriteLine($"Idade digitada: {idade}");
        }
    }
}
