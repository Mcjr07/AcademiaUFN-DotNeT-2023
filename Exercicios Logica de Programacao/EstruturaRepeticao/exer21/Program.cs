namespace exer21;
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double[] notas = new double[4];
        double[] pesos = { 2, 1, 2, 4 };

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double mediaPonderada = (notas[0] * pesos[0] + notas[1] * pesos[1] + notas[2] * pesos[2] + notas[3] * pesos[3]) / pesos.Sum();

        if (mediaPonderada >= 7.0)
            Console.WriteLine("Aluno aprovado!");
        else
            Console.WriteLine("Aluno reprovado!");
        }
    }
}
