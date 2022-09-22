// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
long[] array=CreatyArray(size);
Console.Write($"numbers of array --> ");
PrintArray (array);
Console.WriteLine();
Console.Write($"Amoun of even element of array --> {CountEvenElement(array)}");
Console.WriteLine();



long[] CreatyArray(int size)
{
    long[] array = new long[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (10,20);
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

long CountEvenElement(long[] array)
{ 
long sum=0;
    for (int i=1; i<array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
return sum;
}