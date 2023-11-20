namespace exer31;
public class Program
{
    static void Main()
    {
        Console.Write("Informe o lado a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Informe o lado b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Informe o lado c: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Triângulo Equilátero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Triângulo Isósceles");
            else
                Console.WriteLine("Triângulo Escaleno");
        }
        else
        {
            Console.WriteLine("Esses lados não formam um triângulo.");
        }
    }
}

