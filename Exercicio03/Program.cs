﻿namespace Exercicio03;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a kilometragem inicial: ");
        double kmInicial = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite a kilometragem final: ");
        double kmFinal = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o consumo do combustível após a viagem em litros: ");
        double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

        double distanciaPercorrida = kmFinal - kmInicial;

        double consumoPorKm = distanciaPercorrida / consumoCombustivel;

        Console.WriteLine($"O consumo de combustível durante o percurso foi de +/- {consumoPorKm} km/l!");

        Console.ReadLine();
    }
}
