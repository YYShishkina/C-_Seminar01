// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
int sumNumbers=FindSumNumbers(elementN);
Console.WriteLine($"{sumNumbers}");
Console.WriteLine();

int FindSumNumbers(int numberN)
{
    
    if (numberN==0)
    {
        return 0;
    }
    return numberN%10+FindSumNumbers(numberN/10);
}