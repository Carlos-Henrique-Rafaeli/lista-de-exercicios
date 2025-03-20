namespace Exercicio14;

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

        double[] valoresJuntos = [valorA, valorB, valorC];

        Array.Sort(valoresJuntos);
        Array.Reverse(valoresJuntos);

        Console.Write("Valores em ordem decrescente: ");

        foreach(double valor in valoresJuntos)
            Console.Write($"{valor} ");

        Console.ReadLine();
    }
}
