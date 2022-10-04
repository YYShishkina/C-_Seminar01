// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


Console.Write("Input M --> ");
int elementM = int.Parse(Console.ReadLine()!);
Console.Write("Input N --> ");
int elementN = int.Parse(Console.ReadLine()!);
if (elementM==2 && elementN==3)
{
    int sum = FindAkkerman(elementM,elementN);
    Console.Write($"Akkerman element {elementM} and {elementN} --> {sum}");
}  
else
{
    Console.WriteLine($"Wrong numers,first number must be 2, second number 3");
}  

Console.WriteLine();
//A(m, n) = n + 1, если n = 0,
//A(m, m) = A(n - 1, 1), если n <> 0, m = 0,
//A(m, n) = A(n - 1, A(n, m - 1)), если n> 0, m > 0.

int FindAkkerman(int numberM, int numberN)
{
    int m=2;
    if ((numberM>0) && (numberN>0))
    {
        return numberN+1+FindAkkerman(numberM-1,FindAkkerman(numberM,numberN-1));
    }
    if ((numberM>0) && (numberN==0))
    {
         return numberN+1+FindAkkerman(numberM-1,1);
    }  
    if ((numberM==0) && (numberN==0))
    {
         return numberN+1;
    }
    return 0;
}