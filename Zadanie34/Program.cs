// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7





int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Console.WriteLine();
Console.WriteLine("Created 2DArray");
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();
PrintArray(FindMinElement(array));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("New array without row and column with min element");
array = DeleteRowColumnWithMin(array,FindMinElement(array));
Print2DArray(array);
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

int [] FindMinElement (int[,] array)
{
    int [] pararametrsMin = {array[0,0],0,0}; //в массив сохраняются значение мин, и номер столбца строки в которых рассполеженно минимальное значение 
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
        if (array[i,j]<pararametrsMin[0]) 
            {
            pararametrsMin[0]=array[i,j];
            pararametrsMin[1]=i;
            pararametrsMin[2]=j;
            }
        }
    }
    return pararametrsMin;
}

void PrintArray (int[] array)
{
    Console.Write($"Min element in Arrya is {array[0]} in {array[1]+1} row and {array[2]+1} column");
}

int [,] DeleteRowColumnWithMin(int[,] array, int[]parametrsMin)
{
    int[,] newarray=new int[array.GetLength(0)-1,array.GetLength(1)-1];
    for (int i=0; i<newarray.GetLength(0); i++)
    {
        for (int j=0; j<newarray.GetLength(1); j++)
        {
            if (i<parametrsMin[1] && j<parametrsMin[2]) 
            {
                newarray[i,j]=array[i,j];
            }
            else if (i<parametrsMin[1] && j>=parametrsMin[2])
            {
                newarray[i,j]=array[i,j+1];
            }
            else if (i>=parametrsMin[1] && j<parametrsMin[2])
            {
                newarray[i,j]=array[i+1,j];
            }
            else
            {
                newarray[i,j]=array[i+1,j+1];
            }
        }
    }
    return newarray;
}

