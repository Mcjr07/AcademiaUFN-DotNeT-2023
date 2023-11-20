namespace exer17;
{
    internal class Program

    static void Main(string[] args)
    {
        int nota;
        int somaNotas = 0;
        int maiorNota = int.MinValue;
        int menorNota = int.MaxValue;
        int numAlunos = 0;

        do
        {
            Console.Write("Digite a nota do aluno (-1 para encerrar): ");
            nota = int.Parse(Console.ReadLine());

            if (nota != -1)
            {
                somaNotas += nota;
                numAlunos++;

                if (nota > maiorNota)
                    maiorNota = nota;
                if (nota < menorNota)
                    menorNota = nota;
            }

        } while (nota != -1);

        if (numAlunos > 0)
        {
            double mediaTurma = somaNotas / (double)numAlunos;
            Console.WriteLine($"Nota mais alta: {maiorNota}");
            Console.WriteLine($"Nota mais baixa: {menorNota}");
            Console.WriteLine($"Média da turma: {mediaTurma}");
            Console.WriteLine($"Quantidade de alunos na turma: {numAlunos}");
        }
        else
        {
            Console.WriteLine("Nenhum aluno registrado.");
        }
    }

}
