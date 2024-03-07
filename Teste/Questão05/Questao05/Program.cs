namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string InverterString(string texto)
            {
                char[] chars = texto.ToCharArray();
                int left = 0;
                int right = chars.Length - 1;

                while (left < right)
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;

                    left++;
                    right--;
                }

                return new string(chars);
            }

            // Exemplo de uso
            string texto = "Olá, mundo!";
            string textoInvertido = InverterString(texto);
            Console.WriteLine($"Texto original: {texto}");
            Console.WriteLine($"Texto invertido: {textoInvertido}");
        }
    }
}
