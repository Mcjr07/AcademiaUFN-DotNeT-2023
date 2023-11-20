namespace exer30;

class Program
{
    static void Main()
    {
        Console.Write("Placar (time da casa x time de fora): ");
        string placar = Console.ReadLine();

        int golsCasa = int.Parse(placar.Split('x')[0]);
        int golsFora = int.Parse(placar.Split('x')[1]);

        if (golsFora - golsCasa > 2)
        {
            Console.WriteLine("O time de fora já se classificou para a próxima fase.");
        }
        else
        {
            Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
            Console.Write("Placar do segundo jogo: ");
            string placar2 = Console.ReadLine();

            int golsCasa2 = int.Parse(placar2.Split('x')[0]);
            int golsFora2 = int.Parse(placar2.Split('x')[1]);

            if (golsFora2 > golsCasa2)
            {
                Console.WriteLine("O time de fora passou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("O time da casa passou para a próxima fase.");
            }
        }
    }
}
