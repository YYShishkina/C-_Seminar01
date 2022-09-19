// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача Г. Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая проверяет, верно ли, что числа в массиве идут по возрастанию. 
//Если очередное число меньше предыдущего, ответ — нет.

void CreateArrayCheckGrowth ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    Console.Write($"Array --> ");
    int chechgrowth = 0;
    array[0]=new Random().Next(0,11);//массив запоняется случайными числами от 0 до 10
    Console.Write($"{array[0]},");
    for (int i =1; i<8; i++)
    {
        array[i]=new Random().Next(0,11);//массив запоняется случайными числами от 0 до 10
        Console.Write($"{array[i]},");
        if (array[i-1]<=array[i])
        {
            chechgrowth++;
        }
    }
    if (chechgrowth == 7)
    {
        Console.WriteLine();
        Console.WriteLine ($"all number in array growth--> Yes");
    }
    else 
    {
        Console.WriteLine();
        Console.Write ($"are all number in array growth --> No");
    }
}

CreateArrayCheckGrowth();
Console.WriteLine();