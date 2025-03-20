namespace Exercicio17;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor de A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de B: ");
        int valorB = Convert.ToInt32(Console.ReadLine());

        int resultado;

        if (valorA == valorB)
        {
            resultado = valorA + valorB;
            Console.WriteLine($"Os valores de A({valorA}) e B({valorB}) são iguais");
            Console.WriteLine($"A soma deles ficou {resultado}");
        }
        else
        {
            resultado = valorA * valorB;
            Console.WriteLine($"Os valores de A({valorA}) e B({valorB}) são diferentes");
            Console.WriteLine($"A multiplicação deles ficou {resultado}");
        }


        Console.ReadLine();
    }
}
