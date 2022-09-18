// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]


void CreateArray ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    cdConsole.Write($"Array --> ");
    for (int i =0; i<8; i++)
    {
        array[i]=new Random().Next(0,2);
        Console.Write($"{array[i]},");
    }
}

CreateArray();
Console.WriteLine();