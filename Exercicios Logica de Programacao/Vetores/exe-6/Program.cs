namespace exe6;

public class Program
{
    static void Main(string[] args)
    {
        // Defina o tamanho do vetor
        int tamanhoDoVetor = 10;

        // Crie o vetor
        int[] vetor = new int[tamanhoDoVetor];

        // Preencha o vetor com valores fornecidos pelo usuário
        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out vetor[i]) == false)
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número inteiro.");
                i--;
            }
        }

        // Escreva os números na ordem contrária à ordem de leitura
        Console.WriteLine("Números na ordem contrária à ordem de leitura:");
        for (int i = tamanhoDoVetor - 1; i >= 0; i--)
        {
            Console.Write($"{vetor[i]} ");
        }

        // Aguarde o usuário pressionar Enter antes de encerrar o programa
        Console.ReadLine();
    }
}
    }
}