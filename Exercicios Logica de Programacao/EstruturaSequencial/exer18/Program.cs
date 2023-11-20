namespace exer18
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Digite a quantidade de horas aula do primeiro professor: ");
        int horasAula1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor por hora do primeiro professor: ");
        double valorHora1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de horas aula do segundo professor: ");
        int horasAula2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor por hora do segundo professor: ");
        double valorHora2 = double.Parse(Console.ReadLine());

        double salario1 = horasAula1 * valorHora1;
        double salario2 = horasAula2 * valorHora2;

        if (salario1 > salario2)
        {
            Console.WriteLine("O primeiro professor tem o maior salário total.");
        }
        else if (salario2 > salario1)
        {
            Console.WriteLine("O segundo professor tem o maior salário total.");
        }
        else
        {
            Console.WriteLine("Os professores têm salários iguais.");
        }
        }
    }
}
