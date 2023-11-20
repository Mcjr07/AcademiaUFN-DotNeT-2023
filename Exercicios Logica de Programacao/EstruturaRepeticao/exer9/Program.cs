namespace EXER9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        int numero;
        do
        {
            Console.Write("Digite um número (0 para parar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                if (numero % 2 == 0)
                    Console.WriteLine($"{numero} é par.");
                else
                    Console.WriteLine($"{numero} é ímpar.");

                bool ehPrimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
                if (numero == 1)
                    ehPrimo = false;

                if (ehPrimo)
                    Console.WriteLine($"{numero} é primo.");
                else
                    Console.WriteLine($"{numero} não é primo.");
            }

        } while (numero != 0);
        }
    }
}
