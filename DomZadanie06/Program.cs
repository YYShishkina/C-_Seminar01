// See https://aka.ms/new-console-template for more information
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 → 5
//78 → третьей цифры нет
//32679 → 6
Console.WriteLine("Input number");
//int number = new Random().Next (0,1000000);
string n1 = Console.ReadLine(); //Ввод любого числа
int number = int.Parse(n1);
//Console.WriteLine($"{number}");

int celaychast = number;
int kolrazr = 0;
if (number < 100) //Анализ есть ли вч числе 3 разрада
{
    Console.WriteLine($"{number}, doesn't have third digit");
    celaychast = 0;
}
else
{
    while (celaychast>0) //Анализ количества разрядов
    {
        celaychast = celaychast/10;
        kolrazr=kolrazr+1;
    }
    celaychast = number;
    //Console. WriteLine($"{celaychast}, {kolrazr}");
    while (kolrazr>3) //Определение 3-го разряда
    {
        celaychast = celaychast/10;
        kolrazr=kolrazr-1;
    }
    //Console. WriteLine($"{celaychast}");
    Console. WriteLine($"Third digit in number is {celaychast%10}");
}
