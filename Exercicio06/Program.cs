namespace Exercicio06;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a primeira nota do aluno: ");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());

        primeiraNota = 1 / primeiraNota;

        Console.Write("Informe a segunda nota do aluno: ");
        double segundaNota = Convert.ToDouble(Console.ReadLine());

        segundaNota = 1 / segundaNota;

        Console.Write("Informe a terceira nota do aluno: ");
        double terceiraNota = Convert.ToDouble(Console.ReadLine());

        terceiraNota = 1 / terceiraNota;

        Console.Write("Informe a quarta nota do aluno: ");
        double quartaNota = Convert.ToDouble(Console.ReadLine());

        quartaNota = 1 / quartaNota;

        double mediaHarmonica = 4 / (primeiraNota + segundaNota + terceiraNota + quartaNota);

        Console.WriteLine($"A média harmônica do aluno é de {mediaHarmonica:F2}");

        Console.ReadLine();
    }
}
