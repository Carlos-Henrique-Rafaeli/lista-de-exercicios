namespace Exercicio20;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um valor para a tabuada: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador++)
        {
            int resultado = contador * valorA;
            Console.WriteLine($"{contador} * {valorA} = {resultado}");
        }

        Console.ReadLine();
    }
}
