namespace exer11;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosJoao = 0;
        int votosZeca = 0;
        int votosBranco = 0;
        int votosNulos = 0;
        int totalVotos = 0;

        string voto;
        do
        {
            Console.Write("Digite o nome do candidato (JOAO, ZECA, BRANCO ou NULO): ");
            voto = Console.ReadLine();

            if (voto.Equals("JOAO", StringComparison.OrdinalIgnoreCase))
                votosJoao++;
            else if (voto.Equals("ZECA", StringComparison.OrdinalIgnoreCase))
                votosZeca++;
            else if (voto.Equals("BRANCO", StringComparison.OrdinalIgnoreCase))
                votosBranco++;
            else if (voto.Equals("NULO", StringComparison.OrdinalIgnoreCase))
                votosNulos++;

            totalVotos++;

        } while (!voto.Equals("FIM", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Votos para JOAO: {votosJoao}");
        Console.WriteLine($"Votos para ZECA: {votosZeca}");
        Console.WriteLine($"Votos em branco: {votosBranco}");
        Console.WriteLine($"Votos nulos: {votosNulos}");
        Console.WriteLine($"Total de pessoas que votaram: {totalVotos}");

        if (votosJoao > votosZeca)
            Console.WriteLine("Candidato vencedor: JOAO");
        else if (votosZeca > votosJoao)
            Console.WriteLine("Candidato vencedor: ZECA");
        else
            Console.WriteLine("Empate entre JOAO e ZECA");
    
        }
    }
}
