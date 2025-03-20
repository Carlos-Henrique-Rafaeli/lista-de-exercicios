namespace Exercicio13;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe valor de A: ");
        double valorA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe valor de B: ");
        double valorB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe valor de C: ");
        double valorC = Convert.ToDouble(Console.ReadLine());

        if (valorA + valorB < valorC)
            Console.WriteLine("A soma de A + B é menor do que C");
        else if (valorA + valorB == valorC)
            Console.WriteLine("A soma de A + B é igual à C");
        else
            Console.WriteLine("A soma de A + B é maior do que C");

        Console.ReadLine();
    }
}
