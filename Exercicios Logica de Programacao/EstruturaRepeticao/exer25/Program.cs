namespace exer27;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
        int numFilhos;
        double somaSalarios = 0;
        int somaFilhos = 0;
        int numPessoas = 0;
        int numSalarioAte100 = 0;

        do
        {
            Console.Write("Digite o salário (ou um número negativo para encerrar): ");
            salario = double.Parse(Console.ReadLine());

            if (salario >= 0)
            {
                Console.Write("Digite o número de filhos: ");
                numFilhos = int.Parse(Console.ReadLine());

                somaSalarios += salario;
                somaFilhos += numFilhos;
                numPessoas++;

                if (salario <= 100)
                    numSalarioAte100++;
            }

        } while (salario >= 0);

        if (numPessoas > 0)
        {
            double mediaSalario = somaSalarios / numPessoas;
            double mediaFilhos = somaFilhos / (double)numPessoas;
            double percentualSalarioAte100 = (numSalarioAte100 / (double)numPessoas) * 100;

            Console.WriteLine($"Média do salário da população: {mediaSalario:C}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F}");
            Console.WriteLine($"Maior salário: {somaSalarios:C}");
            Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {percentualSalarioAte100:F}%");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi registrado.");
        }
        
    }
}
