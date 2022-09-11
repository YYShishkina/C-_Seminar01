// 3. Пользователь вводит a и b. Программа печатает все числа от a до b.
//Например: 2, 6 → 2 3 4 5 6
Console.Write($"Введите число A и B ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
if (int.Parse (coordinate[0]) > int.Parse (coordinate[1]))
{
    for (int i = int.Parse (coordinate[0]); i >= int.Parse (coordinate[1]); i=i-1)
    {
        Console.Write($"{i},");
    }     
}
else if (int.Parse (coordinate[0]) < int.Parse (coordinate[1]))
{
    for (int i = int.Parse (coordinate[0]); i <= int.Parse (coordinate[1]); i=i+1)
    {
        Console.Write($"{i},");
    }   
}
else 
{
    Console.WriteLine($"x=y");
} 
Console.WriteLine($" ");