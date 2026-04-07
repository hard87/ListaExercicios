// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Digite a largura da caixa:");
double largura = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite a altura da caixa:");
double altura = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite a profundidade da caixa:");
double profundidade = Convert.ToDouble(Console.ReadLine());
double volume = largura * altura * profundidade;
System.Console.WriteLine($"O volume da caixa é: {volume}");

