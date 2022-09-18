// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

void MultiplicationN (int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result*i;
    }
    Console.Write ($"Multiplication from 1 to {number} --> {result}");
    Console.WriteLine();
}
    
Console.Write("input number --> ");
int n = int.Parse (Console.ReadLine()!);
MultiplicationN(n);
