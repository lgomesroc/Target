namespace Questao02
{
    public class Questao02
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }


        static bool PertenceFibonacci(int numero)
        {
            // Cálculo dos primeiros 100 números de Fibonacci
            int[] fibonacci = new int[100];
            for (int i = 0; i < 100; i++)
            {
                fibonacci[i] = Fibonacci(i);
            }

            // Verifica se o número está presente no array
            return Array.Exists(fibonacci, x => x == numero);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            bool pertence = PertenceFibonacci(numero);

            if (pertence)
            {
                Console.WriteLine("O número {0} pertence à sequência de Fibonacci.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} não pertence à sequência de Fibonacci.", numero);
            }
        }

    }
}
