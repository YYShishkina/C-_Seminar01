// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = InputNumber();
int b = InputNumber();
int c = InputNumber();
Proverka(a,b,c);

int InputNumber()
{
    Console.Write($"input first number --> ");
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Proverka(int a,int b, int c)
{
if (a+b>c && a+c>b && b+c>a)
{
    Console.WriteLine($"There is triangl");
}
else
{
    Console.WriteLine($"There is now such triangle");
}
}