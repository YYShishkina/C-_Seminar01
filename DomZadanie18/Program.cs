// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input parametrs first line:");
Console.Write("Input k1 --> ");
int a1 = InputParametr();
Console.Write("Input k2 --> ");
int a2 = InputParametr();
Console.WriteLine("Input parametrs second line:");
Console.Write("Input k1 --> ");
int b1 = InputParametr();
Console.Write("Input k2 --> ");
int b2 = InputParametr();
FindIntersection(a1,a2,b1,b2);

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


int InputParametr()
{  
    int number = int.Parse(Console.ReadLine()!);
    return number;   
}

void FindIntersection(int a1, int a2, int b1, int b2)
{
    if (a1==b1)
    {
        Console.WriteLine($"Lines are not cross");
    }
    else if (a2==b2)
    {
        Console.WriteLine($"Lines cross in poin (0,{a2})");
    }
    else 
    {
        int x = (b2-b1)/(a1-a2);
        int y = a1*x+b1;
        int checky =a2*x+b2; 
        Console.WriteLine($"Lines cross in poin ({x},{y})");
        //Console.WriteLine($"Additional verification ({x},{checky})");
    }
    
}


