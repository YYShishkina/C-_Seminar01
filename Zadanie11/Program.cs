// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Write($"Введите номер четверти ");
string A = Console.ReadLine()!;
//string[] coordinate = A.Split(" ");
int x = int.Parse(A);
//int y = int.Parse (coordinate[1]);

if ( x== 1)
{
    Console.WriteLine($"Диапазон координат в {x}-й четверти, x>0 и y>0");
}
else if (x == 2)
{
    Console.WriteLine($"Диапазон координат в {x}-й четверти x<0 и y>0");
}
else if (x == 3)
{
    Console.WriteLine($"Диапазон координат в {x}-й четверти x<0 и y<0");
}
else if (x == 4)
{
    Console.WriteLine($"Диапазон координат в {x}-й четверти x>0 b y<0");
}
else 
{
     Console.WriteLine($"Указан не корректный номер четверти");
}