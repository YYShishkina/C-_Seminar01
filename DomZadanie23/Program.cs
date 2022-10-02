// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Console.WriteLine();
Console.WriteLine("Created 2DArray");
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();
PrintMinArray(FindSumElementsInRow(array));
Console.WriteLine();

    

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
            numbers[i,j] = new Random().Next(-10,21);
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

int [] FindSumElementsInRow(int [,] array)
{
    int[] arrayWithSumElementsInRow = new int [array.GetLength(0)];
        for (int i=0; i<array.GetLength(0); i++)
        {
            int sumElementsInRow = 0;
            for (int j=0; j<array.GetLength(1); j++)
            {
                sumElementsInRow=sumElementsInRow+array[i,j];
            }
            arrayWithSumElementsInRow[i]=sumElementsInRow;
        }
    return arrayWithSumElementsInRow;
}

void PrintMinArray(int[] array)
{
    int min = array[0];
    int numberOfMin = 0;
    for (int i=1; i<array.Length; i++)
    {
        if (min>array[i])
        {
            min=array[i];
            numberOfMin=i;
        }
    }
    Console.Write($"The minimal sum of elements is {min} in {numberOfMin+1} row");
}