// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void SumDigitsNumber (int number )
{
    int counter = 0;
    int remainder = number;
    int sumdigits = 0;
    while (number !=0 )
    {
        number = number/10;
        counter++;
        sumdigits=sumdigits+remainder%10;
        remainder=number;
    }
    Console.Write($"Sum of digits --> {sumdigits}");
    Console.WriteLine();
}

Console.Write("input number --> ");
int number = int.Parse(Console.ReadLine()!);
SumDigitsNumber(number);