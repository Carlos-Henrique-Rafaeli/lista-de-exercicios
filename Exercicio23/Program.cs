namespace Exercicio23;

internal class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 100; contador++)
        {
            if (contador % 3 == 0 && contador % 5 == 0)
                Console.WriteLine($"FizzBuzz ({contador})");
            else if (contador % 3 == 0)
                Console.WriteLine($"Fizz ({contador})");
            else if (contador % 5 == 0)
                Console.WriteLine($"Buzz ({contador})");
            else
                Console.WriteLine(contador);
        }


        Console.ReadLine();
    }
}
