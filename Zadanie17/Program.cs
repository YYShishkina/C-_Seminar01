// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void FindSumNegativPositivNumbArray ()
{
    const int Size = 12;
    long[] array = new long[Size];
    Console.Write ("Array --> ");
    long negativSum=0;
    long positivSum=0;
    for (int i=0; i< array.Length; i++)
    {
        array[i]=new Random().Next (-9,10);
        Console.Write ($"{array[i]}, ");
        if (array[i]<0)
        {
            negativSum = negativSum+array[i];
        }
        else
        {
            positivSum = positivSum+array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Sum negativ numbers of array --> {negativSum}");
    Console.WriteLine($"Sum positiv numbers of array --> {positivSum}");
}
    

    

FindSumNegativPositivNumbArray();
Console.WriteLine();