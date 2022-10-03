// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N по убыванию.
// M = 1; N = 5 -> "5, 4, 3, 2, 1"
// M = 4; N = 8 -> "8, 7, 6, 5, 4"


Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
Console.Write("Input M --> ");
int elementM = int.Parse(Console.ReadLine()!);
if (elementM>=elementN)
{
    Console.WriteLine($"{elementM} must be smoller then {elementN}");
}
else
{
    PrintNumbers(elementN, elementM);
}
Console.WriteLine();

void PrintNumbers(int numberN, int numberM)
{
    if (numberN >= numberM)
    {
        PrintNumbers(numberN,numberM+1);
        Console.Write($"{numberM} ");
    }
}
