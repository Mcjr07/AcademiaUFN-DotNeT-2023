namespace exer24;

class Program
{
    static void Main()
    {
        string nome1, nome2;
        int idade1, idade2;
        double altura1, altura2;

        Console.WriteLine("Informe os dados do primeiro atleta:");
        Console.Write("Nome: ");
        nome1 = Console.ReadLine();
        Console.Write("Idade: ");
        idade1 = int.Parse(Console.ReadLine());
        Console.Write("Altura (em metros): ");
        altura1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme os dados do segundo atleta:");
        Console.Write("Nome: ");
        nome2 = Console.ReadLine();
        Console.Write("Idade: ");
        idade2 = int.Parse(Console.ReadLine());
        Console.Write("Altura (em metros): ");
        altura2 = double.Parse(Console.ReadLine());

        if (idade1 < idade2)
        {
            Console.WriteLine("Atleta mais novo: " + nome1);
        }
        else
        {
            Console.WriteLine("Atleta mais novo: " + nome2);
        }

        if (altura1 > altura2)
        {
            Console.WriteLine("Atleta mais alto: " + nome1);
        }
        else
        {
            Console.WriteLine("Atleta mais alto: " + nome2);
        }
    }
}

