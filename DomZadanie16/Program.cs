//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
long[] array=CreatyArray(size);
Console.Write($"numbers of array --> ");
PrintArray (array);
Console.WriteLine();
Console.Write($"Difference between max and min element of array --> {FindMaxMin(array)}");
Console.WriteLine();



long[] CreatyArray(int size)
{
    long[] array = new long[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (-100,101);
    } 
    return array;
}

void PrintArray(long[] array)
{
    foreach (long number in array)
    {
        Console.Write($"{number}, ");
    }
    Console.WriteLine();
}

long FindMaxMin(long[] array)
{ 
long max=array[0];
long min=array[0];
    for (int i=1; i<array.Length; i++)
    {
        if (max<array[i])
        {
            max =array[i];
        }
        else if (array[i]<min)
        {
            min=array[i];
        }
    }
    Console.WriteLine($"min element of array --> {min}, max element of array --> {max}");
    long difference=max-min;
return difference;
}