// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Digite a temperatura em Celsius: ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
System.Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit} °F");