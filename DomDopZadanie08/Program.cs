// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача Б. Программа заполняет массив 8 случайными числами. 
//Напишите функцию, которая принимает массив и находит в нём наибольший элемент. 
//Используйте накопительную переменную. 
//Эта переменная изначально равна первому элементу массива; 
//когда встречается лучший кандидат на максимум, она его запоминает.


void CreateArrayFindMax ()
{
    int[] array = {1,1,1,1,1,1,1,1};
    Console.Write($"Array --> ");
    int max = array[1];
    for (int i =0; i<8; i++)
    {
        array[i]=new Random().Next(0,51);//массив запоняется случайными числами от 0 до 50
        Console.Write($"{array[i]},");
        if (max < array[i])
        {
            max = array[i];
        } 
    }
    Console.WriteLine();
    Console.Write ($"max number of array --> {max}");
}

CreateArrayFindMax();
Console.WriteLine();