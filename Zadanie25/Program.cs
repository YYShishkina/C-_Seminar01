// See https://aka.ms/new-console-template for more information
Console.Write("Input N --> ");
//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int N = int.Parse(Console.ReadLine()!);
Fibonach(N);
Console.WriteLine();

void Fibonach(int N)
{
  int f1=0;
  int f2=1;
  Console.Write($"{f1} {f2} ");
    for (int i=3; i<=N; i++)
    {
       int f3=f1+f2;
       f1=f2;
       f2=f3;
       Console.Write($"{f3} ");
    }
    
}