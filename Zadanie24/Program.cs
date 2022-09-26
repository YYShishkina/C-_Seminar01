// See https://aka.ms/new-console-template for more information
Console.Write("Input number --> ");
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
int number10=int.Parse(Console.ReadLine()!);
Console.Write($"Number in Binary system is --> ");
int[] array=ChangeToBinary(number10);
Console.Write($"Number in Binary system is --> ");
Printarray(array);
Console.WriteLine();

int [] ChangeToBinary(int number10)
{
    List<int> result = new List<int>();
    int ostdel=number10;
    int i=0;
    while(ostdel>=2)
    {
        Console.Write($"{ostdel%2}");
        result.Add(ostdel%2);
        ostdel=ostdel/2;
        i++;
    }
    Console.WriteLine($"{ostdel}");
    //i++;
    result.Add(ostdel);
    return result.ToArray();
}


void Printarray(int[] array)
{
    for (int i=array.Length-1; i>=0; i--)
    {
        Console.Write(array[i]);
    }
}

double Fibonachi(int n)
{
    if (n==1||n==2)
    {
        return 1;
    }
    else return Fibonachi(n-1)+Fibonachi(n-2);
}