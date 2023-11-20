namespace exer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
        Console.Write("Digite o valor da quantia solicitada: ");
        int quantia = int.Parse(Console.ReadLine());

        var distribuicao = CalcularDistribuicaoOptima(quantia);

        Console.WriteLine("Distribuição ótima de notas:");
        foreach (var nota in distribuicao)
        {
            Console.WriteLine($"Notas de R${nota.Key:C}: {nota.Value}");
        }
    }

    static Dictionary<int, int> CalcularDistribuicaoOptima(int quantia)
    {
        int[] notas = { 50, 20, 10, 5, 1 };
        var distribuicao = new Dictionary<int, int>();

        foreach (var nota in notas)
        {
            if (quantia >= nota)
            {
                int numNotas = quantia / nota;
                distribuicao[nota] = numNotas;
                quantia -= numNotas * nota;
            }
        }

        return distribuicao;
    }
        }
    }
}
