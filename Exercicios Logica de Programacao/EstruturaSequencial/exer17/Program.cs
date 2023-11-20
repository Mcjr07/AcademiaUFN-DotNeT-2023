namespace exer17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[4];
        int soma = 0;

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            valores[i] = int.Parse(Console.ReadLine());
            soma += valores[i];
        }

        double media = (double)soma / 4;

        Console.WriteLine("Valores superiores à média:");

        foreach (int valor in valores)
        {
            if (valor > media)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
