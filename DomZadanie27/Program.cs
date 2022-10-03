// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"



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
        PrintNumbers(numberN-1,numberM);
        Console.Write($"{numberN} ");
    }
}
