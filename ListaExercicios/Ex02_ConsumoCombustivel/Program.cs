// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Digite a Km inicial: ");
double kmInicial = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a Km final: ");
double kmFinal = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade de litros consumidos: ");
double litrosConsumidos = double.Parse(Console.ReadLine());
double consumoMedio = (kmFinal - kmInicial) / litrosConsumidos;

System.Console.WriteLine($"O consumo médio do veículo é: {consumoMedio} Km/l");