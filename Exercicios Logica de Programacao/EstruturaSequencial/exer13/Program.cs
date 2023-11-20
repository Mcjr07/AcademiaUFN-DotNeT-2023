namespace exer13;

internal class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário que insira o valor do salário mínimo
        Console.Write("Digite o valor do salário mínimo: ");
        double salarioMinimo = double.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o preço de custo de cada bicicleta
        Console.Write("Digite o preço de custo de cada bicicleta: ");
        double precoCustoBicicleta = double.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o número de bicicletas vendidas pelo vendedor
        Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
        int numeroBicicletasVendidas = int.Parse(Console.ReadLine());

        // Calcula o salário base do vendedor (2 salários mínimos)
        double salarioBase = 2 * salarioMinimo;

        // Calcula a comissão do vendedor (15% sobre o preço de custo de cada bicicleta vendida)
        double comissao = 0.15 * precoCustoBicicleta * numeroBicicletasVendidas;

        // Calcula o salário total do vendedor (salário base + comissão)
        double salarioTotal = salarioBase + comissao;

        // Exibe o resultado
        Console.WriteLine($"O salário do empregado é: R$ {salarioTotal:N2}");
    }
}
