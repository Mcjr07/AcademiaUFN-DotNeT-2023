namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite o valor da mercadoria:");
        decimal valorMercadoria = Convert.ToDecimal(Console.ReadLine());

        if (valorMercadoria <= 0)
        {
            Console.WriteLine("O valor da mercadoria deve ser maior que zero.");
            return;
        }

        decimal entrada;
        decimal prestacoes;

        // Calcula a entrada e as prestações
        if (valorMercadoria % 3 == 0)
        {
            entrada = valorMercadoria / 3;
            prestacoes = entrada;
        }
        else
        {
            entrada = Math.Floor(valorMercadoria / 3) + (valorMercadoria % 3);
            prestacoes = Math.Ceiling(valorMercadoria / 3);
        }

        Console.WriteLine($"Valor da entrada: R$ {entrada:0.00}");
        Console.WriteLine($"Valor das duas prestações: R$ {prestacoes:0.00}");
    
        }
    }
}
