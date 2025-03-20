namespace Exercicio08;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor do número para saber se ele é primo: ");
        int numeroInformado = Convert.ToInt32(Console.ReadLine());
        bool ehPrimo = true;

        if (numeroInformado > 1)
        {
            for (int contador = 2; contador < numeroInformado; contador++)
            {
                if (numeroInformado % contador == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
        }
        else
            ehPrimo = false;


        if (ehPrimo)
            Console.WriteLine($"O número {numeroInformado} é primo!");
        else
            Console.WriteLine($"O número {numeroInformado} não é primo!");

        Console.ReadLine();
    }
}
