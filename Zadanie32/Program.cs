// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя

int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
if (height!=width)
{
    Console.WriteLine("You can't replace rows and columns");
}
else 
{
    int [,] array = new int [height,width];
    Console.WriteLine();
    Console.WriteLine("Created 2DArray");
    array = Fill2DArray(array);
    Print2DArray(array);
    Console.WriteLine("Modified 2DArray");
    array= ReplaceRowColumn(array);
    Print2DArray(array);
}

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

int [,] ReplaceRowColumn(int [,] array)
{
    int temp=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=i; j<array.GetLength(1); j++)
        {
            temp=array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=temp;
        }
    }
    return array;
}