namespace Exercicio19;

internal class Program
{
    static void Main(string[] args)
    {
        int somaTotal = 0;

        for (int contador = 1; contador <= 500; contador++)
        {
            if (contador % 2 != 0 && contador % 3 == 0)
                somaTotal += contador;
        }

        Console.WriteLine($"A soma total dos números ímpares e múltiplos de 3 de 1 à 500 é de {somaTotal}");

        Console.ReadLine();
    }
}
