// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
Console.Write("Input M --> ");
int elementM = int.Parse(Console.ReadLine()!);
int sumNumbers=FindDegreeNumbers(elementN, elementM);
Console.WriteLine($"{sumNumbers}");
Console.WriteLine();

int FindDegreeNumbers(int numberN, int numberM)
{
    
    if (numberM==0)
    {
        return 1;
    }
    return numberN*FindDegreeNumbers(numberN, numberM-1);
}