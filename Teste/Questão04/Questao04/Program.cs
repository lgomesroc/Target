using System;

class Program
{
    static void Main(string[] args)
    {
        // Leitura do peso e altura do usuário
        Console.Write("Digite seu peso (em kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        // Cálculo do IMC
        double imc = peso / (altura * altura);

        // Exibição do resultado
        Console.WriteLine();
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Classificação do IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso ideal");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Obesidade grau III");
        }
    }
}
