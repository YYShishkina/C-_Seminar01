// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
Console.Write("Input M --> ");
int elementM = int.Parse(Console.ReadLine()!);
if (elementM>=elementN)
{
    Console.WriteLine($"Wrong numers,first number must be bigger then second number");
}
else
{
    int sum = FindSumNumbers(elementN,elementM);
    Console.Write($"Sum element betwin {elementM} and {elementN} --> {sum}");
   
}
Console.WriteLine();


int FindSumNumbers(int numberN, int numberM)
{
    
    if (numberN==numberM)
    {
        return numberM;
    }
    return numberN+FindSumNumbers(numberN-1, numberM);
}