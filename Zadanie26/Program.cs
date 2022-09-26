// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
int[] array=new int[size];
int[] copyarray=new int[size];
PrintArray(array);
Console.WriteLine();
array=FillArray(array);
PrintArray(array);
Console.WriteLine();
copyarray = CopyArray(array);
PrintArray (copyarray);
Console.WriteLine();

int[] CreatyArray(int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (0,11);
    } 
    return array;
}

void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        Console.Write($"{number}, ");
    }
    Console.WriteLine();
}

int[] FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,11);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newarray= new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        newarray[i]=array[i];
    }
    return newarray;
}