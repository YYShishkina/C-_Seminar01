//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5



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
        array[i]= new Random().Next (100,1000);
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

int CountEvenElement(long[] array)
{
int j = 0;    
    for (int i=0; i<array.Length; i++)
    {
    if ((array[i]%2) == 0)
    j=j+1;
    }
return j;
}