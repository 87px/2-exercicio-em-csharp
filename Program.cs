using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Insira a temperatura em Celsius: ");
        String celsiusValue = Console.ReadLine()!;

        double celsius = Convert.ToDouble(celsiusValue); // Conversão do valor para decimal;
        double fahrenheit = (celsius * 1.8) + 32; // Para converter a fórmula é fazer vezes 1.8 e então somar por 32;

        Console.WriteLine("Valor inserido (Celsius): " + celsius);
        Console.WriteLine("Valor em fahrenheit: " + fahrenheit);
    }
}

