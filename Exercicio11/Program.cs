namespace Exercicio11;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é seu nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Quantos anos você tem: ");
        int idadeAnos = Convert.ToInt32(Console.ReadLine());

        int idadeDias = idadeAnos * 365;

        Console.WriteLine($"{nome}, você ja viveu {idadeDias} dias!");

        Console.ReadLine();
    }
}
