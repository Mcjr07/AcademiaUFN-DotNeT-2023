namespace Aula4
{
    public class Program
    {
        static void Main(string[] args)
        {
             double distanciaPercorridaKm;
            double volumeCombustivelLitros;
            double consumoMedioKmPorLitro;

            Console.WriteLine("Calculadora de Consumo Médio de Automóvel");
            Console.WriteLine("=========================================");
            
            Console.Write("Informe a distância total percorrida (em km): ");
            distanciaPercorridaKm = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o volume de combustível consumido (em litros): ");
            volumeCombustivelLitros = double.Parse(Console.ReadLine());
            
            consumoMedioKmPorLitro = distanciaPercorridaKm / volumeCombustivelLitros;
            
            Console.WriteLine($"O consumo médio do automóvel é de {consumoMedioKmPorLitro:F2} km/l.");
        
        }
    }
}