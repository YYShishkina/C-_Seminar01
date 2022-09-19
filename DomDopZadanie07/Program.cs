// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача А. Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая находит среднее арифметическое чисел в массиве. 
//Среднее арифметическое равно сумме, делёной на количество.

void CreateArrayPrinAverage ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    Console.Write($"Array --> ");
    int average = 0;
    for (int i =0; i<8; i++)
    {
        array[i]=new Random().Next(0,11);//массив запоняется случайными числами от 0 до 20
        Console.Write($"{array[i]},");
        average = average+array[i];
    }
    average = average/8;
    Console.WriteLine();
    Console.Write ($"arithmetic mean of an array --> {average}");
}

CreateArrayPrinAverage();
Console.WriteLine();