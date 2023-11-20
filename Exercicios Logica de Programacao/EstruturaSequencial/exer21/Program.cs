namespace exe21;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine("Digite a palavra de pesquisa: ");
        string palavraPesquisa = Console.ReadLine();

        if (ContemPalavra(frase, palavraPesquisa))
        {
            Console.WriteLine("A palavra encontra-se na frase.");
        }
        else
        {
            Console.WriteLine("A palavra não se encontra na frase.");
        }
    }

    static bool ContemPalavra(string frase, string palavraPesquisa)
    {
        // Dividir a frase em palavras usando espaços como delimitadores
        string[] palavras = frase.Split(' ');

        // Verificar se a palavra de pesquisa está na lista de palavras
        foreach (string palavra in palavras)
        {
            if (palavra.Equals(palavraPesquisa, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}
