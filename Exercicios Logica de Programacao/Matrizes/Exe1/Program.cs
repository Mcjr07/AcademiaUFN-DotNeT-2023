namespace exe1;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];

            // Preencha a primeira coluna com entrada do usuário
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um valor para a primeira coluna da linha " + (i + 1) + ": ");
                matriz[i, 0] = Convert.ToInt32(Console.ReadLine());
            }

            // Preencha a segunda coluna com a soma da primeira coluna + 10
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
            }

            // Preencha a terceira coluna com o dobro da primeira coluna
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
            }

        }
    }
}
