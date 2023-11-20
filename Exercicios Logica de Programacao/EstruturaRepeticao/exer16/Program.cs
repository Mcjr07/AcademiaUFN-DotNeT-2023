namespace exer16;
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numPessoas = 50;
        int numMasculino = 0, numFeminino = 0, numMenos30 = 0, numMais60 = 0;
        int somaIdadesMulheres = 0;

        for (int i = 0; i < numPessoas; i++)
        {
            Console.Write($"Digite o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();

            Console.Write($"Digite o sexo da pessoa {i + 1} (M/F): ");
            char sexo = char.Parse(Console.ReadLine());

            Console.Write($"Digite a idade da pessoa {i + 1}: ");
            int idade = int.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
                numMasculino++;
            else if (sexo == 'F' || sexo == 'f')
            {
                numFeminino++;
                if (idade < 30)
                    numMenos30++;
                if (idade > 60)
                    numMais60++;
                somaIdadesMulheres += idade;
            }
        }

        Console.WriteLine($"Número de pessoas do sexo masculino: {numMasculino}");
        Console.WriteLine($"Número de pessoas do sexo feminino: {numFeminino}");
        Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {numMenos30}");
        Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {numMais60}");
        Console.WriteLine($"Média de idade das mulheres: {somaIdadesMulheres / (double)numFeminino}");
    
        
    }
}
