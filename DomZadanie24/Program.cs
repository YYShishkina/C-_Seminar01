// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Created first 2DArray");
int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] firstArray = new int [height,width];
firstArray = Fill2DArray(firstArray);
Print2DArray(firstArray);
Console.WriteLine();
Console.WriteLine("Created second 2DArray");
height = InputHeightWidth("Input Height");
width = InputHeightWidth("Input Width");
int [,] secondArray = new int [height,width];
secondArray = Fill2DArray(secondArray);
Print2DArray(secondArray);
Console.WriteLine();
if (firstArray.GetLength(1)!=secondArray.GetLength(0))
{
    Console.WriteLine("This Arrays can't be multiplication");
}
else
{
    Console.WriteLine("The result multiplication first and second 2DArray");
    Print2DArray(FindMultiOf2DArrays(firstArray,secondArray));
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
            numbers[i,j] = new Random().Next(1,3);
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

int [,] FindMultiOf2DArrays(int [,] firstArray, int [,] secondArray)
{
    int[,] arrayResult = new int [firstArray.GetLength(0),secondArray.GetLength(1)];
    
    for (int i=0; i<firstArray.GetLength(0); i++)
        {
            for (int j=0; j<secondArray.GetLength(1); j++)
            {
                for (int k=0; k<secondArray.GetLength(1); k++)
                {
                    arrayResult[i,j] = arrayResult[i,j]+firstArray[i,k]*secondArray[k,j];
                }  
            }
        }
    return arrayResult;
}
