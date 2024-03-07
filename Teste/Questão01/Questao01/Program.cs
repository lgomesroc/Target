namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K++;

                SOMA += K;
            }

            Console.WriteLine(SOMA);
        }
    }
}
