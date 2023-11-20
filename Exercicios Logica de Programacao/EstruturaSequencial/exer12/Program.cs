namespace exer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Lê a marcação do odômetro no início do dia
        Console.Write("Digite a marcação do odômetro no início do dia (em km): ");
        double odometroInicio = double.Parse(Console.ReadLine());

        // Lê a marcação do odômetro no final do dia
        Console.Write("Digite a marcação do odômetro no final do dia (em km): ");
        double odometroFinal = double.Parse(Console.ReadLine());

        // Lê o número de litros de combustível gasto
        Console.Write("Digite o número de litros de combustível gasto: ");
        double litrosCombustivel = double.Parse(Console.ReadLine());

        // Lê o valor total recebido dos passageiros
        Console.Write("Digite o valor total recebido dos passageiros (em R$): ");
        double valorTotalRecebido = double.Parse(Console.ReadLine());

        // Calcula o total de quilometragem percorrida
        double totalQuilometragem = odometroFinal - odometroInicio;

        // Calcula a média do consumo em Km/l
        double mediaConsumo = totalQuilometragem / litrosCombustivel;

        // Calcula o lucro líquido do dia
        double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);

        // Exibe os resultados
        Console.WriteLine($"Média do consumo: {mediaConsumo:F2} Km/l");
        Console.WriteLine($"Lucro líquido do dia: R${lucroDia:F2}");   
        }
    }
}