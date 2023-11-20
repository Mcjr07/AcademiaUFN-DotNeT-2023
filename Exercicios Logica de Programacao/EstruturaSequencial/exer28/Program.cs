namespace exer28;

class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho do arquivo em MB: ");
        double tamanhoArquivo = double.Parse(Console.ReadLine());

        Console.Write("Informe a velocidade da Internet em Mbps: ");
        double velocidadeInternet = double.Parse(Console.ReadLine());

        double tempoDownloadMinutos = (tamanhoArquivo * 8) / (velocidadeInternet * 60);
        Console.WriteLine($"Tempo aproximado de download: {tempoDownloadMinutos} minutos");
    }
}
