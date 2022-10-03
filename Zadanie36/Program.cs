// See https://aka.ms/new-console-template for more information
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
PrintNumbers(elementN);
Console.WriteLine();

void PrintNumbers(int number)
{
    if (number > 0)
    {
        PrintNumbers(number-1);
        Console.Write($"{number} ");
    }
}


