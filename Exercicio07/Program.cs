namespace Exercicio07;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a nota da primeira prova: ");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o peso da primeira prova: ");
        double primeiroPeso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a nota da segunda prova: ");
        double segundaNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o peso da segunda prova: ");
        double segundoPeso = Convert.ToDouble(Console.ReadLine());

        double somaNotas = (primeiraNota * primeiroPeso) + (segundaNota * segundoPeso);
        double somaPesos = primeiroPeso + segundoPeso;

        double resultado = somaNotas / somaPesos;

        Console.WriteLine($"A sua média ponderada é {resultado:F2}");

        Console.ReadLine();
    }
}
