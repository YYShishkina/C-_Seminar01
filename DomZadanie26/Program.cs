// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Console.WriteLine();
Console.WriteLine("Created 2DArray");
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();


    

int InputHeightWidth( string comments)
{
    Console.Write($"{comments} --> ");
    return int.Parse(Console.ReadLine()!);
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

int[,] Fill2DArray (int [,] numbers)
{
    int fillDirection=0;
    int row = 0;
    int column=0;
    int element = 0;
    //int turnCounter=0;

    for (int i=0; i<2*numbers.GetLength(0)-1; i++)
    {
        if (fillDirection==0) 
        {
            for (int j=column; j<numbers.GetLength(0)-column;j++)
            {
                numbers[row,j]=element;
                element++;
            }
            fillDirection=1;
        }
        else if (fillDirection==1)
        {
            for (int j=row+1; j<numbers.GetLength(1)-row; j++)
            {
                numbers[j,numbers.GetLength(1)-column-1]=element;
                element++;
            }
            fillDirection=2;
        }
        else if (fillDirection==2)
        {
            for (int j=numbers.GetLength(0)-column-2; j>=column; j--)
            {
                numbers[numbers.GetLength(0)-row-1,j]=element;
                element++;
            }
            fillDirection=3;
        }
        else if (fillDirection==3)
        {
            for (int j=numbers.GetLength(1)-row-2; j>row; j--)
            {
                numbers[j,column]=element;
                element++;
            }
            fillDirection=0;
            column++;
            row++;
        }
    }
    return numbers;
}
