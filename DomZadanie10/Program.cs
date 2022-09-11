//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

string input1 = Console.ReadLine()!;
int n = int.Parse (input1);
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i*i},");   
}
Console.WriteLine($" ");