//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Input number");
string n1 = Console.ReadLine()!; //Ввод любого числа
int number = int.Parse(n1);
if ((number < 9999) || (number>99999)) //Анализ есть ли в числе 5 разрядов
{
    Console.WriteLine($"{number}, doesn't have five digit");
}
else if ((number/10000) == (number%10)&&(number/1000%10) == (number/10%10))
{
    Console. WriteLine($"{number} - polyndrom");
}
else 
{
    Console. WriteLine($"{number} - is not polyndrom");
}