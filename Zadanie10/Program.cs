// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"Введите Х и Н, ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
int x = int.Parse (coordinate[0]);
int y = int.Parse (coordinate[1]);

if (x>0 && y>0)
{
    Console.WriteLine($"Точка А с координатами ({x},{y}), расположена в 1-й четверти");
}
else if (x<0 && y>0)
{
    Console.WriteLine($"Точка А с координатами ({x},{y}), расположена в 2-й четверти");
}
else if (x<0 && y<0)
{
    Console.WriteLine($"Точка А с координатами ({x},{y}), расположена в 3-й четверти");
}
else if (x>0 && y<0)
{
    Console.WriteLine($"Точка А с координатами ({x},{y}), расположена в 4-й четверти");
}
else 
{
     Console.WriteLine($"Точка А с некорректными координатами");
}