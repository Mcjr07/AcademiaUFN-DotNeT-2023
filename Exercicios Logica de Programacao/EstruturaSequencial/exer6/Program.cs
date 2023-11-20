namespace exer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o número do vendedor
            Console.Write("Digite o número do vendedor: ");
            int numeroVendedor = int.Parse(Console.ReadLine());

            // Solicita ao usuário o salário fixo do vendedor
            Console.Write("Digite o salário fixo do vendedor: ");
            double salarioFixo = double.Parse(Console.ReadLine());

            // Solicita ao usuário o total de vendas efetuadas pelo vendedor
            Console.Write("Digite o total de vendas efetuadas pelo vendedor: ");
            double totalVendas = double.Parse(Console.ReadLine());

            // Solicita ao usuário o percentual de comissão do vendedor
            Console.Write("Digite o percentual de comissão do vendedor (em %): ");
            double percentualComissao = double.Parse(Console.ReadLine());

            // Calcula o valor da comissão em reais
            double comissao = (percentualComissao / 100) * totalVendas;

            // Calcula o salário total do vendedor
            double salarioTotal = salarioFixo + comissao;

            // Exibe o número do vendedor e o salário total
            Console.WriteLine($"Número do vendedor: {numeroVendedor}");
            Console.WriteLine($"Salário total do vendedor: R${salarioTotal:F2}");
            
        }
    }
}
