// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int [,] array = new int [height,width];
Console.WriteLine();
Console.WriteLine("Created 2DArray");
array = Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();
PrintArray(CheckElements(array));
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
            numbers[i,j] = new Random().Next(0,5);
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

int [] CheckElements (int[,] array)
{
    int [] checkArray = new int[2*array.GetLength(0)*array.GetLength(1)];
    int k=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            checkArray[k]=array[i,j];
            checkArray[k+1]=DictionaryElements(array[i,j], array);
            k=k+2;
        }
    }
    return checkArray;
}


int DictionaryElements (int element, int [,] array)
{
    int counter=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (element == array[i,j])
            {
                counter=counter+1;
            }
        }
    }
return counter;
}

void PrintArray (int[] array)
{
    int k=0;
    for (int i=0; i<array.Length; i=i+2){
        for (int j=i; j<array.Length; j=j+2)
        {
            if (array[i]==array[j])
            {
                k=k+1;
            } 
        }
        if (array[i+1]==k) 
        {
            Console.WriteLine($"Elemet {array[i]} meets {array[i+1]} times");
        }    
        k=0;
    }
}

