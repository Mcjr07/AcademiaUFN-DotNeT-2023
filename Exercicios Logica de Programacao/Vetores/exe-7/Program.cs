namespace exe7;
{
    public class Program

    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int[] pares = new int[10];
        int[] impares = new int[10];
        int contadorPares = 0;
        int contadorImpares = 0;

        Console.WriteLine("Digite dez números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares[contadorPares] = numeros[i];
                contadorPares++;
            }
            else
            {
                impares[contadorImpares] = numeros[i];
                contadorImpares++;
            }
        }

        Console.WriteLine("Números pares lidos:");
        for (int i = 0; i < contadorPares; i++)
        {
            Console.Write(pares[i] + "|");
        }

        Console.WriteLine();

        Console.WriteLine("Números ímpares lidos:");
        for (int i = 0; i < contadorImpares; i++)
        {
            Console.Write(impares[i] + "|");
        }

        Console.WriteLine();
    }


}