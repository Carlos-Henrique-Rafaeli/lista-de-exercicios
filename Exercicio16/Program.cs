namespace Exercicio16;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para saber se ele é par ou ímpar: ");
        int numeroInformado = Convert.ToInt32(Console.ReadLine());

        if (numeroInformado % 2 == 0)
            Console.WriteLine($"O número {numeroInformado} é par");
        else
            Console.WriteLine($"O número {numeroInformado} é ímpar");

        Console.ReadLine();
    }
}
