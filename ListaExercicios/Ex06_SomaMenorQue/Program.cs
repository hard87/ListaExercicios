System.Console.WriteLine("Digite um número inteiro positivo para A:");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite um número inteiro positivo para B:");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite um número inteiro positivo para C:");
int c = int.Parse(Console.ReadLine());

if (a + b < c)
{
    System.Console.WriteLine("A soma de A e B é menor que C.");
}
else
{
    System.Console.WriteLine("A soma de A e B não é menor que C.");
}