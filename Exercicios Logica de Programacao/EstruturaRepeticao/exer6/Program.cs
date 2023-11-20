namespace exer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de avaliações: ");
        int quantidadeAvaliacoes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            double somaNotas = 0;

            for (int j = 1; j <= quantidadeAvaliacoes; j++)
            {
                Console.Write($"Digite a nota da avaliação {j} do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somaNotas += nota;
            }

            double media = somaNotas / quantidadeAvaliacoes;
            Console.WriteLine($"A média do aluno {i} é {media}");
           
        }
    }
}
