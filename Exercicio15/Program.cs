namespace Exercicio15;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe seu peso em Kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double indiceMassaCorporal = peso / (Math.Pow(altura, 2));

        if (indiceMassaCorporal < 18.5)
            Console.WriteLine($"Seu IMC é de {indiceMassaCorporal:F2}, você está abaixo do peso!");

        else if (indiceMassaCorporal > 18.5 && indiceMassaCorporal < 25)
            Console.WriteLine($"Seu IMC é de {indiceMassaCorporal:F2}, você está com peso normal!");

        else if (indiceMassaCorporal > 25 && indiceMassaCorporal < 30)
            Console.WriteLine($"Seu IMC é de {indiceMassaCorporal:F2}, você está acima do peso!");

        else if (indiceMassaCorporal > 30)
            Console.WriteLine($"Seu IMC é de {indiceMassaCorporal:F2}, você está obeso!");

        Console.ReadLine();
    }
}
