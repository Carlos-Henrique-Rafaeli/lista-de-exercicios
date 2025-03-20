namespace Exercicio21;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um valor para a calcular o fatorial: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        int valorFatorial = 1;

        for (int contador = valorA; contador > 1; contador--)
        {
            valorFatorial *= contador;
        }

        Console.WriteLine($"O fatorial de {valorA} é {valorFatorial}");

        Console.ReadLine();
    }
}
