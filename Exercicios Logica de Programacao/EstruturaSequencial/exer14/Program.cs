namespace exer14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Área de Triângulo");
        
        Console.Write("Digite o valor da base: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor da altura: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        if (baseTriangulo <= 0 || alturaTriangulo <= 0)
        {
            Console.WriteLine("A base e a altura devem ser maiores que zero.");
        }
        else
        {
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
        }
        
    }
}
