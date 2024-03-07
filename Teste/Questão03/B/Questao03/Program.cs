namespace Questao03
{
    internal class Program
    {
        static int Fatorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Fatorial(n - 1);
        }

    static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fatorial(i));
            }
        }
    }
}
