namespace exe9;
{
    internal class Program

    static void Main(string[] args)
    {
        int[,] matriz3x3 = new int[3, 3];
        Console.WriteLine("Digite os elementos da matriz 3x3:");
        LerMatriz(matriz3x3);

        Console.Write("Digite um número para pesquisar na matriz: ");
        int numeroPesquisa = int.Parse(Console.ReadLine());

        bool numeroExiste = PesquisarNumero(matriz3x3, numeroPesquisa);

        if (numeroExiste){
            Console.WriteLine("O número existe na matriz.");
        else
            Console.WriteLine("Número inexistente.");
        
    }

}
