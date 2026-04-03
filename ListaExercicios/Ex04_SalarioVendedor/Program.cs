// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Digite o nome do vendedor: ");
string nomeVendedor = Console.ReadLine();
System.Console.WriteLine("Digite o salário fixo do vendedor: ");
double salarioFixo = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o valor total das vendas do vendedor: ");
double valorVendas = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a porcentagem de comissão do vendedor: ");
double porcentagemComissao = double.Parse(Console.ReadLine());
double comissao = valorVendas * (porcentagemComissao / 100);
double salarioTotal = salarioFixo + comissao;
System.Console.WriteLine($"O salário total de {nomeVendedor} é: R$ {salarioTotal:F2}");
