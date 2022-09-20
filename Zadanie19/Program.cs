
Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
Console.Write($"Input the number in array --> ");
long number = long. Parse(Console.ReadLine()!);
long[] array=CreatyArray(size);
PrintArray (array);
FindNumberInArray(number, array);
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

void FindNumberInArray(long number,long[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (number==array[i])
        {
        count = count + 1;
        }
    }
    if (count >0)
    {
        Console.WriteLine($"{number} is in array");
    }
    
    else
    {
        Console.WriteLine($"{number} is not in array");
    }
}
