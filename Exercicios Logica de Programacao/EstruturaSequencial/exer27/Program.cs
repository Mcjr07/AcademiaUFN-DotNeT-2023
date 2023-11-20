namespace exer27;

class Program
{
    static void Main()
    {
        Console.Write("Informe a altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        double pesoIdealHomem = (72.7 * altura) - 58;
        double pesoIdealMulher = (62.1 * altura) - 44.7;

        Console.WriteLine("Peso ideal para homem: " + pesoIdealHomem + " kg");
        Console.WriteLine("Peso ideal para mulher: " + pesoIdealMulher + " kg");
    }
}
