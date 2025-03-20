namespace Exercicio05;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o salário base: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor total de vendas: ");
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da porcentagem de comissão de vendas: ");
        double porcentagemVendas = Convert.ToDouble(Console.ReadLine());

        porcentagemVendas = porcentagemVendas / 100;

        double resultado = salarioBase + (totalVendas * porcentagemVendas);

        Console.WriteLine($"O salário no final do mês vai ser {resultado:F2}");

        Console.ReadLine();
    }
}
