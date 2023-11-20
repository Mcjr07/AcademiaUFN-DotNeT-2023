namespace exer15;
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        int[] filhos = new int[30];
        int entre1e3 = 0, entre4e7 = 0, maisDe8 = 0, semFilhos = 0;

        for (int i = 0; i < 30; i++)
        {
            Console.Write($"Digite a quantidade de filhos da pessoa {i + 1}: ");
            filhos[i] = int.Parse(Console.ReadLine());

            if (filhos[i] >= 1 && filhos[i] <= 3)
                entre1e3++;
            else if (filhos[i] >= 4 && filhos[i] <= 7)
                entre4e7++;
            else if (filhos[i] > 8)
                maisDe8++;
            else if (filhos[i] == 0)
                semFilhos++;
        }

        Console.WriteLine($"Pessoas com entre 1 e 3 filhos: {entre1e3}");
        Console.WriteLine($"Pessoas com entre 4 e 7 filhos: {entre4e7}");
        Console.WriteLine($"Pessoas com mais de 8 filhos: {maisDe8}");
        Console.WriteLine($"Pessoas sem filhos: {semFilhos}");
        }
    }
}
