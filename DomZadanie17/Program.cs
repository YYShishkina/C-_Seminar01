// See https://aka.ms/new-console-template for more information
Console.Write("How many number you want to check --> ");
int M = InputNumber();
Console.WriteLine($"There are {CounterNegativNumber(M)} negativ numbers");

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


int InputNumber()
{
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int CounterNegativNumber(int number)
{
    int newnumber = 0;
    int count = 0;
    for (int i=1; i<=number; i++)
    {
        Console.Write($"Input {i} number --> ");
        newnumber = InputNumber();
        Console.WriteLine();
        if (newnumber<0)
        {
            count=count+1;
        }  
    }
    return count;
}
