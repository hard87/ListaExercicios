// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine();

System.Console.WriteLine("Digite a nota da primeira prova: ");
double nota1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o peso da primeira prova: ");
double peso1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite a nota da segunda prova: ");
double nota2 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o peso da segunda prova: ");
double peso2 = double.Parse(Console.ReadLine());

System.Console.WriteLine($"A média ponderada de {nomeAluno} é: {(nota1 * peso1 + nota2 * peso2) / (peso1 + peso2):F2}");
