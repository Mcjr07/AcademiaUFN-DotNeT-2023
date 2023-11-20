using System;

class NuMp
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        bool primo = VerificarPrimo(numero);
        if (primo)
        {
            Console.WriteLine($"{numero} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número primo.");
        }
    }

    static bool VerificarPrimo(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
