// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void DischargeCounter (int number )
{
    int counter = 0;
    while (number !=0 )
    {
        number = number/10;
        counter++;
    }
    Console.Write($"Number of digits --> {counter}");
    Console.WriteLine();
}

Console.Write("input number --> ");
int number = int.Parse(Console.ReadLine()!);
DischargeCounter(number);
