namespace Exercicio04;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da temperatura em Celsius (°C): ");
        double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

        double temperaturaFahrenheit = temperaturaCelsius * 1.8 + 32;

        Console.WriteLine($"A temperatura {temperaturaCelsius:F2}(°C) em Fahrenheit é {temperaturaFahrenheit:F2}(°F)");

        Console.ReadLine();
    }
}
