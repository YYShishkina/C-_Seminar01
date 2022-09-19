// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Задача В. Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая проверяет, верно ли, что все числа в массиве чётные. 
//Наличие хотя бы одного нечётного числа означает, что ответ — нет.

void CreateArrayCheckParity ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    Console.Write($"Array --> ");
    int sumremainder = 0;
    for (int i =0; i<8; i++)
    {
        array[i]=new Random().Next(0,11);//массив запоняется случайными числами от 0 до 10
        Console.Write($"{array[i]},");
        sumremainder = sumremainder + array[i]%2;
    }
    if (sumremainder == 0)
    {
        Console.WriteLine();
        Console.WriteLine ($"are all number in array even --> Yes");
    }
    else 
    {
        Console.WriteLine();
        Console.Write ($"are all number in array even --> No");
    }
}

CreateArrayCheckParity();
Console.WriteLine();