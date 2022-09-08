// See https://aka.ms/new-console-template for more information
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 → 5
//782 → 8 
//918 → 1

Console.WriteLine("Hello, World!");
int number = new Random().Next (100,1000);
Console.WriteLine($"{number}");
Console.WriteLine($"{(number/10)%10}");