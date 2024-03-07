namespace Questao03
{
    internal class Program
    {
        static int SomaImpares(int n)
        {
            if (n == 0)
                return 0;
            else if (n % 2 == 1)
                return n + SomaImpares(n - 2);
            else
                return SomaImpares(n - 1);
        }


        static void Main(string[] args)
        {
            int somaImpares = SomaImpares(10);
            Console.WriteLine(somaImpares);
        }
    }
}
