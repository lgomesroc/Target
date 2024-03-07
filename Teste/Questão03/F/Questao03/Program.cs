namespace Questao03
{
    internal class Program
    {
        ]static int MaximoArray(int[] array)
        {
            int maximo = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximo)
                    maximo = array[i];
            }
            return maximo;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 10, 5, 2, 7, 1 };
            int maximo = MaximoArray(numeros);
            Console.WriteLine(maximo);
        }
    }
}
