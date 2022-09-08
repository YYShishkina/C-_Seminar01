// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int dayn = new Random().Next (1,8);
Console.WriteLine($"Input day number, {dayn}");
if (dayn<=5)
{
    Console.WriteLine($"{dayn} is a working day");
}
else 
{
    Console.WriteLine($"{dayn} is a day off");
}