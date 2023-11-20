namespace exer25;
class Program
{
    static void Main()
    {
        Console.Write("Digite a hora (0 a 23): ");
        int hora = int.Parse(Console.ReadLine());
        Console.Write("Digite os minutos (0 a 59): ");
        int minutos = int.Parse(Console.ReadLine());

        if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
        {
            Console.WriteLine("A hora é válida.");
        }
        else
        {
            Console.WriteLine("A hora não é válida.");
        }
    }
}

