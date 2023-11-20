namespace exer26;

class Program
{
    static void Main()
    {
        Console.Write("Informe o código do operário: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Informe o número de horas trabalhadas: ");
        int numeroHoras = int.Parse(Console.ReadLine());

        double salarioPorHora = 10.0;
        double salarioTotal = numeroHoras * salarioPorHora;
        double extra = 0.0;

        if (numeroHoras > 50)
        {
            extra = (numeroHoras - 50) * 20.0;
            numeroHoras = 50; // Limita o número de horas a 50 para calcular o salário base
        }

        salarioTotal = numeroHoras * salarioPorHora;

        Console.WriteLine("Salário total: R$ " + salarioTotal);
        Console.WriteLine("Salário excedente: R$ " + extra);
    }
}

