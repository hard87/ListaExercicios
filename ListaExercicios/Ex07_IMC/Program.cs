
System.Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

System.Console.WriteLine("Digite seu Peso em kg:");
double peso = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite sua Altura em metros:");
double altura = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite seu Sexo (M para masculino, F para feminino):");
char sexo = char.Parse(Console.ReadLine().ToUpper());

System.Console.WriteLine("Digite sua Idade:");
int idade = int.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

if (sexo == 'M')
{
    if (imc < 20.7)
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está abaixo do peso.");
    }
    else if (imc >= 20.7 && imc < 26.4)
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está com peso ideal.");
    }
    else
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está acima do peso.");
    }
}
else if (sexo == 'F')
{
    if (imc < 19.1)
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está abaixo do peso.");
    }
    else if (imc >= 19.1 && imc < 25.8)
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está com peso ideal.");
    }
    else
    {
        System.Console.WriteLine($"{nome}, seu IMC é {imc:F2}. Você está acima do peso.");
    }
}
else
{
    System.Console.WriteLine("Sexo inválido. Por favor, insira M para masculino ou F para feminino.");
}

