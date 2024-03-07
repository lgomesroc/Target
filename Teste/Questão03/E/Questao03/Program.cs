namespace Questao03
{
    internal class Program
    {
        static int MinimoArray(int[] array)
        {
            int minimo = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimo)
                    minimo = array[i];
            }
            return minimo;
        }


        static void Main(string[] args)
        {
            int[] numeros = { 10, 5, 2, 7, 1 };
            int minimo = MinimoArray(numeros);
            Console.WriteLine(minimo);
        }
    }
}
