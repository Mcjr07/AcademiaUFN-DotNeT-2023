namespace exer29;


class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho em metros quadrados da área a ser pintada: ");
        double areaASerPintada = double.Parse(Console.ReadLine());

        double litrosNecessarios = areaASerPintada / 3;
        int latasNecessarias = (int)Math.Ceiling(litrosNecessarios / 18);
        double precoTotal = latasNecessarias * 80.00;

        Console.WriteLine($"Quantidade de latas de tinta: {latasNecessarias}");
        Console.WriteLine($"Preço total: R$ {precoTotal:F2}");
    }
}
