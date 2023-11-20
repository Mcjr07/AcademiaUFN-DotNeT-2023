namespace exer34;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número secreto entre 1 e 100
        int tentativas = 3;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

        while (tentativas > 0)
        {
            Console.WriteLine("Tentativas restantes: " + tentativas);
            Console.Write("Digite seu palpite: ");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número secreto.");
                break;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }

            tentativas--;
        }

        if (tentativas == 0)
        {
            Console.WriteLine("Suas tentativas acabaram. O número secreto era: " + numeroSecreto);
        }
    }
}

