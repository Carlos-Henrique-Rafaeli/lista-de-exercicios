namespace Exercicio10;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a quantidade de pães vendidos: ");
        double paoFrances = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a quantidade de broas vendidas: ");
        double broa = Convert.ToDouble(Console.ReadLine());

        double valorVendaDiaria = (paoFrances * 0.12) + (broa * 1.5);

        double valorParaGuardar = valorVendaDiaria * 0.1;

        Console.WriteLine($"No final do dia foi arrecadado {valorVendaDiaria:F2} reais");
        Console.WriteLine($"Desses é recomendado guardar na poupança {valorParaGuardar:F2} reais");

        Console.ReadLine();
    }
}
