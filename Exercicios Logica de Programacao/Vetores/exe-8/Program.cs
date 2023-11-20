namespace exe8;

public class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[30];

        Console.WriteLine("Digite trinta números reais:");

        for (int i = 0; i < 30; i++)
        {
            numeros[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Posições dos números menores que zero:");

        for (int i = 0; i < 30; i++)
        {
            if (numeros[i] < 0)
            {
                Console.Write(i + 1 + "|"); // Adiciona 1 para exibir a posição começando em 1, em vez de 0.
            }
        }

        Console.WriteLine();
    }


}
