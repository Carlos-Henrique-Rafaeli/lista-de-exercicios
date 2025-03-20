namespace Exercicio22;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos número da Sequência de Fibonacci devem aparecer: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        int ultimoNumero = 0;
        int penultimoNumero = 1;

        for (int contador = 0; contador < valorA; contador++)
        {
            int resultado = ultimoNumero + penultimoNumero;
            
            penultimoNumero = ultimoNumero;
            ultimoNumero = resultado;
            
            Console.Write($"{ultimoNumero} ");
        }

        Console.ReadLine();
    }
}
