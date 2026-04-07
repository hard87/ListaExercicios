// See https://aka.ms/new-console-template for more information

char resposta;
do{
    Console.WriteLine("Digite um número:");
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
            }
            System.Console.WriteLine("Deseja continuar? (S/N)");
            resposta = char.Parse(Console.ReadLine().ToUpper());
            
            if (resposta == 'N')
            {
                System.Console.WriteLine("Programa encerrado.");
                break;
                }
}while (resposta == 'S');