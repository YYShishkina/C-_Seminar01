// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//, 5 -> 243 (3⁵)
//2, 4 -> 16

void Exponentiation (int NumberA, int NumberB)
{
    int result = 1;
    for (int i = 1; i <= NumberB; i++)
    {
        result = result*NumberA;
    }
    Console.Write ($"{NumberA} to the power of a {NumberB} is --> {result}");
    Console.WriteLine();
}
    
Console.Write("input NumberA --> ");
int nA = int.Parse (Console.ReadLine()!);
Console.Write("input NumberB --> ");
int nB = int.Parse (Console.ReadLine()!);
Exponentiation(nA, nB);