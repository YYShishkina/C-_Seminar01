//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Console.WriteLine();
Console.WriteLine("Created 2DArray");
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine("Array with sorted rows");
Print2DArray(SortRowInArray(array));
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

int [,] SortRowInArray(int [,] array)
{
    for (int k=0; k<array.GetLength(0); k++)
    {
        for (int i=0; i<array.GetLength(1); i++)
        {
            int temp = 0;
            for (int j=1; j<array.GetLength(1); j++)
            {
                if (array[k,j-1]>array[k,j])
                {
                    temp=array[k,j];
                    array[k,j]=array[k,j-1];
                    array[k,j-1]=temp;
                }          
            }
        }
    }
    return array;
}