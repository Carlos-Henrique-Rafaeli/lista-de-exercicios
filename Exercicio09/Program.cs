namespace Exercicio09;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o comprimento do terreno: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a largura do terreno: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        double area = comprimento * largura;

        Console.WriteLine($"A área do terreno é de {area} m²");

        Console.ReadLine();
    }
}
