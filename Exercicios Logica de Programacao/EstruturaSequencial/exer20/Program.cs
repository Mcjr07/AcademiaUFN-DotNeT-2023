namespace exer20;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a altura (metros): ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Digite o peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"IMC de {nome}: {imc:F2}");

        if (imc < 18)
        {
            Console.WriteLine("Situação: Baixo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Situação: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Situação: Sobrepeso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Situação: Obesidade");
        }
        else
        {
            Console.WriteLine("Situação: Obesidade grau sério");
        }
    }
}

