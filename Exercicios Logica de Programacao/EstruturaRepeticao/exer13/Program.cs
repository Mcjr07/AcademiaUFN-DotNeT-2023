namespace EXER13;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
        do
        {
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))
                Console.WriteLine("Nome incorreto.");

        } while (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _));

        int idade;
        do
        {
            Console.Write("Digite a idade (maior que zero): ");
        } while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0);

        double salario;
        do
        {
            Console.Write("Digite o salário (maior que zero): ");
        } while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0);

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: {salario:C}");
        }
    }
}
