// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);

long[] array=CreatyArray(size);
PrintArray (array);
PrintArray (ChangeElements(array));
Console.WriteLine();



long[] CreatyArray(int size)
{
    long[] array = new long[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (-10,11);
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

long[] ChangeElements(long[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=array[i]*(-1);
    }   
    return array;
}

