namespace EXER10;

public class Program
{
    static void Main(string[] args)
    {
       
    int votosJoao = 0;
    int votosZeca = 0;
    int votosBranco = 0;

    string voto;
    do
    {
        Console.Write("Digite o nome do candidato (JOAO, ZECA ou BRANCO): ");
        voto = Console.ReadLine();

        if (voto.Equals("JOAO", StringComparison.OrdinalIgnoreCase))
            votosJoao++;
        else if (voto.Equals("ZECA", StringComparison.OrdinalIgnoreCase))
            votosZeca++;
        else if (voto.Equals("BRANCO", StringComparison.OrdinalIgnoreCase))
            votosBranco++;

    } while (!voto.Equals("FIM", StringComparison.OrdinalIgnoreCase));

    Console.WriteLine($"Votos para JOAO: {votosJoao}");
    Console.WriteLine($"Votos para ZECA: {votosZeca}");
    Console.WriteLine($"Votos em branco: {votosBranco}");
    
}
