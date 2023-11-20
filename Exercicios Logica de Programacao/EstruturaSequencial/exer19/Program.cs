namespace exe19;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o código do funcionário: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o salário base do funcionário: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o total de vendas do funcionário: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        double salarioFinal = salarioBase;

        if (totalVendas > 500.00)
        {
            salarioFinal += totalVendas * 0.05; // Adiciona 5% do total de vendas ao salário final
        }

        if (totalVendas > 1000.00)
        {
            salarioFinal += totalVendas * 0.07; // Adiciona 7% do total de vendas ao salário final
        }

        if (totalVendas > 5000.00)
        {
            salarioFinal += totalVendas * 0.10; // Adiciona 10% do total de vendas ao salário final
        }

        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário Final: R$" + salarioFinal);
    }
}
