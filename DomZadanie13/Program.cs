// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
//1, 2, 5, 7, 19, 0, 1, 2 ->
//[1, 2, 5, 7, 19, 0, 1, 2] 
//6, 1, 33 -> [6, 1, 33]

void CreateArray ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    
    for (int i =0; i<8; i++)
    {
        Console.Write($"Array[{i}] --> ");
        array[i] = int.Parse (Console.ReadLine()!);
    }
    Console.Write($"Array --> ");
    for (int i =0; i<8; i++)
    {
        Console.Write($"{array[i]},");
    }
}

CreateArray();
Console.WriteLine();
