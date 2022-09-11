// 2. Пользователь вводит x и y. Программа печатает, какое отношение верно:
//x < y
//x = y
////x > y
//Например: 3, 7 → 3 < 7
Console.Write($"Введите значения Х и Y ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
if (int.Parse (coordinate[0]) > int.Parse (coordinate[1]))
{
    Console.WriteLine($"x>y");
}
else if (int.Parse (coordinate[0])== int.Parse (coordinate[1]))
{
    Console.WriteLine($"x=y");
}
else 
{
    Console.WriteLine($"x<y");
} 
