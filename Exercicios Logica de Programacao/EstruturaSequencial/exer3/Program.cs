using System;

namespace exer3
{
    public class Program
    {
        static void Main(string[] args)
        {
             // Solicita a data na forma DDMMAAAA
        Console.Write("Digite a data no formato DDMMAAAA: ");
        string dataDDMMAAAA = Console.ReadLine();

        // Verifica se a entrada possui 8 caracteres (DDMMAAAA)
        if (dataDDMMAAAA.Length != 8)
        {
            Console.WriteLine("Formato de data inválido. Certifique-se de que a data tem 8 caracteres (DDMMAAAA).");
            return;
        }

        // Divide a entrada em dia, mês e ano
        string dia = dataDDMMAAAA.Substring(0, 2);
        string mes = dataDDMMAAAA.Substring(2, 2);
        string ano = dataDDMMAAAA.Substring(4, 4);

        // Imprime a data no formato AAAAMMDD
        string dataAAAAMMDD = ano + mes + dia;
        Console.WriteLine("Data no formato AAAAMMDD: " + dataAAAAMMDD);

        // Imprime a data no formato AAMMDD
        string dataAAMMDD = ano.Substring(2) + mes + dia;
        Console.WriteLine("Data no formato AAMMDD: " + dataAAMMDD);
        }
    }
}