//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
/

/ See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write($"Input number of array --> ");
int size= int. Parse(Console.ReadLine()!);
int[] array=new int[size];
PrintArray(array);
Console.WriteLine();
array=FillArray(array);
PrintArray(array);
Console.WriteLine();
array = Reverse(array);
PrintArray (array);
Console.WriteLine();

int[] FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,11);
    }
    return array;
}


int[] Reverse(int[] array)
{
    int temp =0;
    for (int i =0; i<array.Length/2; i++)
    {
        temp = array[i];
        array[i]=array[array.Length-i-1];
        array[array.Length-i-1]=temp;
    }
    return array;
}


void PrintArray(int[] array)
{
    //for (int i=0; i<array.Length; i++)
    //{
        Console.Write(string.Join(",", array));
    //}
}