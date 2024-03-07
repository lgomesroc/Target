namespace Questao03
{
    internal class Program
    {
        static int SomaPares(int n)
        {
            if (n == 0)
                return 0;
            else if (n % 2 == 0)
                return n + SomaPares(n - 2);
            else
                return SomaPares(n - 1);
        }

        static void Main(string[] args)
        {
            int somaPares = SomaPares(10);
            Console.WriteLine(somaPares);
        }
    }
}
