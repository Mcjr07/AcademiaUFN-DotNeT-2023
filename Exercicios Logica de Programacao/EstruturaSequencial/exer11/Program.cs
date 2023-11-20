namespace exer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        // Solicita o número de eleitores, votos brancos, nulos e válidos
        Console.Write("Informe o número de eleitores: ");
        int numEleitores = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos em branco: ");
        int votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos nulos: ");
        int votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos válidos: ");
        int votosValidos = int.Parse(Console.ReadLine());

        // Calcula o percentual de cada tipo de voto em relação ao total de eleitores
        double percentualBrancos = (votosBrancos * 100.0) / numEleitores;
        double percentualNulos = (votosNulos * 100.0) / numEleitores;
        double percentualValidos = (votosValidos * 100.0) / numEleitores;

        // Exibe os resultados
        Console.WriteLine($"Percentual de votos em branco: {percentualBrancos:F2}%");
        Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
        Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");

        }
    }
}
