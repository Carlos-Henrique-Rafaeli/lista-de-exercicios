namespace Exercicio12;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe seu salário atual: ");
        double salarioAtual = Convert.ToDouble(Console.ReadLine());

        double salarioAumento = salarioAtual + (salarioAtual * 0.15);

        double salarioDesconto = salarioAumento - (salarioAumento * 0.08);

        Console.WriteLine($"Seu sálario de R${salarioAtual:F2} com o aumento era para ficar R${salarioAumento:F2},\nMas com impostos ficou R${salarioDesconto:F2}!");

        Console.ReadLine();
    }
}
