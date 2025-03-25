namespace Exercicio22;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        int ultimoNumero = 0;
        int penultimoNumero = 1;

        Console.Write($"{ultimoNumero} {penultimoNumero} ");


        while (ultimoNumero < valorA)
        {
            int resultado = ultimoNumero + penultimoNumero;
            
            Console.Write($"{resultado} ");

            penultimoNumero = ultimoNumero;
            ultimoNumero = resultado;

        }

        Console.ReadLine();
    }
}
