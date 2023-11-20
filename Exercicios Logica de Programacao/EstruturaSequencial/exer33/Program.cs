namespace exer33;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite três valores:");
        double valor1 = double.Parse(Console.ReadLine());
        double valor2 = double.Parse(Console.ReadLine());
        double valor3 = double.Parse(Console.ReadLine());

        double[] valores = { valor1, valor2, valor3 };
        Array.Sort(valores);

        Console.WriteLine("Valores em ordem crescente:");
        foreach (double valor in valores)
        {
            Console.WriteLine(valor);
        }
    }
}
