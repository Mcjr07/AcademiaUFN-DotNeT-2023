public class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            int maiorIdade = int.MinValue;
            int numFemininoIdade18a35 = 0;

            int idade;
            char sexo;
            do
            {
                Console.Write("Digite a idade (-1 para encerrar): ");
                idade = int.Parse(Console.ReadLine());

                if (idade != -1)
                {
                    Console.Write("Digite o sexo (M/F): ");
                    sexo = char.Parse(Console.ReadLine());

                    if (idade > maiorIdade)
                        maiorIdade = idade;

                    if (sexo == 'F' || sexo == 'f')
                    {
                        if (idade >= 18 && idade <= 35)
                        {
                            Console.Write("Digite a cor dos olhos (azuis, verdes ou castanhos): ");
                            string corOlhos = Console.ReadLine();

                            Console.Write("Digite a cor dos cabelos (louros, castanhos ou pretos): ");
                            string corCabelos = Console.ReadLine();

                            if (corOlhos.Equals("verdes", StringComparison.OrdinalIgnoreCase) && corCabelos.Equals("louros", StringComparison.OrdinalIgnoreCase))
                            {
                                numFemininoIdade18a35++;
                            }
                        }
                    }
                }

            } while (idade != -1);

            Console.WriteLine($"Maior idade dos habitantes: {maiorIdade}");
            Console.WriteLine($"Número de mulheres com idade entre 18 e 35 anos, olhos verdes e cabelos louros: {numFemininoIdade18a35}");


        }
    }
}
