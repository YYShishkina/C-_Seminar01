// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Print2DArray(array);
Console.WriteLine();
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();
array= ReplaceString(array);
Print2DArray(array);

int InputHeightWidth( string comments)
{
    Console.Write($"{comments} --> ");
    return int.Parse(Console.ReadLine()!);
}

int[,] Fill2DArray (int [,] numbers)
{
    for (int i=0; i<numbers.GetLength(0); i++)
    {
        for (int j=0; j<numbers.GetLength(1); j++)
        {
            numbers[i,j] = new Random().Next(-10,11);
        }
    }
    return numbers;
}

void Print2DArray (int [,] numbers)
{
    for (int i=0; i<numbers.GetLength(0); i++)
    {
        for (int j=0; j<numbers.GetLength(1); j++)
        {
            Console.Write ($"{numbers[i,j],3} ");
        }
        Console.WriteLine();
    }
}

int [,] ReplaceString(int [,] array)
{
    int temp=0;
    for (int j=0; j<array.GetLength(1); j++)
    {
        temp=array[0,j];
        array[0,j]=array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j]=temp;
    }
    return array;
}