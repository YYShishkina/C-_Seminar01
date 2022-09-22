// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
long[] array=CreatyArray(size);
Console.Write($"numbers of array --> ");
PrintArray (array);
Console.WriteLine();
long[] newarray = MultiplyElement(array);
PrintArray (newarray);
Console.WriteLine();



long[] CreatyArray(int size)
{
    long[] array = new long[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (0,11);
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

long[] MultiplyElement(long[] array)
{
    
        long[] newarray = new long[(array.Length+1)/2];
        for (int i=0; i<(array.Length+1)/2; i++)
        {
            newarray[i]=array[i]*array[array.Length-i-1];
        }
    return newarray;
}