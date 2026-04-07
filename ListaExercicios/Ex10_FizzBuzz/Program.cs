// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}