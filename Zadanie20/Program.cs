Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
//Console.Write($"Input the number in array --> ");
//long number = long. Parse(Console.ReadLine()!);
long[] array=CreatyArray(size);
Console.Write($"numbers of array --> ");
PrintArray (array);
Console.WriteLine();
//indNumberInArray(number, array);
//PrintArray (ChangeElements(array));
Console.Write($"numbers than begger then 10 and smaller 100 in array --> ");
long[] newarray=FindAllNumberInArray (array);
PrintArray (newarray);

Console.WriteLine();



long[] CreatyArray(int size)
{
    long[] array = new long[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next (10,200);
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

long[] FindAllNumberInArray (long[] array)
{
    int j=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>=10 && array[i]<=100)
        {
            j=j+1;
        }
    }
    long[] numberinarray = new long[j];
    int k=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>=10 && array[i]<=100)
        {
            numberinarray[k]=array[i];
            k=k+1;
        }
    }
    return numberinarray;
}